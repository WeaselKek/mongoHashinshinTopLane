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

            listak.Sort((x, y) => x.Bodovi.CompareTo(y.Bodovi));

            dataGridViewTabela.DataSource = listak;

            foreach (DataGridViewRow row in dataGridViewTabela.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }

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

        }

        private void btnIzaberiUtakmicu_Click(object sender, EventArgs e)
        {
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
    }
}
