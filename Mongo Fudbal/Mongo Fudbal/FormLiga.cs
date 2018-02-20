using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using Mongo_Fudbal.Funkcije;

namespace Mongo_Fudbal
{
    public partial class FormLiga : Form
    {
        public Liga L { get; set; }

        public FormLiga()
        {
            InitializeComponent();
        }

        private void FormLiga_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("../../slike/pozadina4.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.BackgroundImage = Image.FromFile("../../icons/delete.png");
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDeleteU.BackgroundImage = Image.FromFile("../../icons/delete.png");
            btnDeleteU.BackgroundImageLayout = ImageLayout.Stretch;

            this.Text = L.Ime;
            lblNazivLige.Text = L.Ime + " (" + L.Drzava + ")";

            dataGridViewUtakmice.ColumnCount = 3;
            dataGridViewUtakmice.Columns[0].Name = "";
            dataGridViewUtakmice.Columns[1].Name = "Rezultat";
            dataGridViewUtakmice.Columns[2].Name = "Datum";
            UcitajDGVUtakmice();



        }

        private void UcitajDGVUtakmice()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            dataGridViewUtakmice.Rows.Clear();
            dataGridViewUtakmice.Refresh();

            var utakmiceColl = db.GetCollection<Utakmica>("utakmice");

            var query1 = from utakmica in utakmiceColl.AsQueryable<Utakmica>()
                         where utakmica.Liga.Id == L.Id
                         orderby utakmica.Datum descending
                         select utakmica;

            List<Utakmica> lista = new List<Utakmica>(query1);


            foreach (Utakmica u in lista)
            {               
                Klub klub1 = db.FetchDBRefAs<Klub>(u.Klub1);
                Klub klub2 = db.FetchDBRefAs<Klub>(u.Klub2);                
                var index = dataGridViewUtakmice.Rows.Add();
                dataGridViewUtakmice.Rows[index].Cells[0].Value = klub1.Ime + " - " + klub2.Ime;
                dataGridViewUtakmice.Rows[index].Cells["Rezultat"].Value = u.Rezultat;
                dataGridViewUtakmice.Rows[index].Cells["Datum"].Value = u.Datum.ToString();
                dataGridViewUtakmice.Rows[index].Tag = u.Id;

            }
        }

        private void UcitajDGVTabela()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            List<Klub> listak = new List<Klub>();

            foreach (MongoDBRef klubRef in L.Klubovi.ToList())
            {
                Klub klub = db.FetchDBRefAs<Klub>(klubRef);
                listak.Add(klub);
            }

            listak.Sort((x, y) => y.Bodovi.CompareTo(x.Bodovi));

            dataGridViewTabela.DataSource = listak;

            dataGridViewTabela.Columns["id"].Visible = false;
            dataGridViewTabela.Columns["God_osn"].Visible = false;
            dataGridViewTabela.Columns["Grad"].Visible = false;
            dataGridViewTabela.Columns["Stadion"].Visible = false;
            dataGridViewTabela.Columns["Liga"].Visible = false;
            if (dataGridViewTabela.Columns.Contains("Igraci"))
            {
                dataGridViewTabela.Columns["Igraci"].Visible = false;
            }
            if (dataGridViewTabela.Columns.Contains("Utakmice"))
            {
                dataGridViewTabela.Columns["Utakmice"].Visible = false;
            }
            if (dataGridViewTabela.Columns.Contains("Slika"))
            {
                dataGridViewTabela.Columns["Slika"].Visible = false;
            }

            dataGridViewTabela.ClearSelection();
            
        }

        private void tabLiga_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabLiga.SelectedIndex == 0)
            {

                UcitajDGVUtakmice();

            }
            else if (tabLiga.SelectedIndex == 1)
            {
                UcitajDGVTabela();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajUtakmicu duform = new DodajUtakmicu();
            duform.L = this.L;
            duform.ShowDialog();
            UcitajDGVUtakmice();
        }

        private void dodajKlubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajKlub dkform = new DodajKlub();
            dkform.L = this.L;
            dkform.ShowDialog();
            UcitajDGVTabela();

        }

        private void btnIzaberiUtakmicu_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dataGridViewUtakmice))
                return;
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            FormUtakmica uform = new FormUtakmica();
            ObjectId objid = (ObjectId) dataGridViewUtakmice.CurrentRow.Tag;

            MongoDBRef mref = new MongoDBRef("utakmice", objid);
            Utakmica u = db.FetchDBRefAs<Utakmica>(mref);
            uform.U = u;
            uform.ShowDialog();
            UcitajDGVUtakmice();
        }

        private void btnIzaberiKlub_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dataGridViewTabela))
                return;
            FormKlub formk = new FormKlub();
            Klub k = new Klub();
            k = dataGridViewTabela.CurrentRow.DataBoundItem as Klub;
            formk.K = k;
            formk.ShowDialog();
            UcitajDGVTabela();
        }

        private void dataGridViewTabela_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dataGridViewTabela))
                return;

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var kluboviColl = db.GetCollection<Klub>("klubovi");
            var ligeColl = db.GetCollection<Liga>("lige");

            Klub k = dataGridViewTabela.CurrentRow.DataBoundItem as Klub;
            if (k.Igraci.Count > 0 || k.Utakmice.Count > 0)
            {
                MessageBox.Show("Ne moze da se obrise klub koji sadrzi igrace i/ili utakmice");
                return;
            }
            else
            {
                MongoDBRef kref = new MongoDBRef("klubovi", k.Id);
                L.Klubovi.Remove(kref);
                ligeColl.Save(L);

                kluboviColl.Remove(Query.EQ("_id", k.Id));
                MessageBox.Show("Klub je obrisan");
                UcitajDGVTabela();


            }
        }

        private void btnDeleteU_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dataGridViewUtakmice))
                return;

            var query = Query.Null;
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var utakmiceColl = db.GetCollection<Utakmica>("utakmice");
            var dogadjajiColl = db.GetCollection<Dogadjaj>("dogadjaji");
            var ligeColl = db.GetCollection<Liga>("lige");
            var kluboviColl = db.GetCollection<Klub>("klubovi");

            //pribavljanje utakmice
            ObjectId objid = (ObjectId)dataGridViewUtakmice.CurrentRow.Tag;
            query = Query.EQ("_id", objid);
            Utakmica u = utakmiceColl.Find(query).Single();

            //pribavljanje lige i brisanje utakmice iz liste
            query = Query.EQ("_id", u.Liga.Id);
            Liga lg = ligeColl.Find(query).Single();
            MongoDBRef utakmicaRef = new MongoDBRef("utakmice", objid);
            lg.Utakmice.Remove(utakmicaRef);
            ligeColl.Save(lg);

            //pribavljanje kluba i brisanje utakmice iz liste
            query = Query.EQ("_id", u.Klub1.Id);
            Klub k1 = kluboviColl.Find(query).Single();
            query = Query.EQ("_id", u.Klub2.Id);
            Klub k2 = kluboviColl.Find(query).Single();
            k1.Utakmice.Remove(utakmicaRef);
            k2.Utakmice.Remove(utakmicaRef);
            kluboviColl.Save(k1);
            kluboviColl.Save(k2);

            //brisanje dogadjaja
            foreach (MongoDBRef d in u.Dogadjaji)
            {
                query = Query.EQ("_id", d.Id);
                dogadjajiColl.Remove(query);
            }

            //brisanje utakmica
            query = Query.EQ("_id", objid);
            utakmiceColl.Remove(query);
            UcitajDGVUtakmice();
        }
    }
}
