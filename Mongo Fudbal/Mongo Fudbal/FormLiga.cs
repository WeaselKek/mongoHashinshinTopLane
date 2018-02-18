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
            UcitajDGVUtakmice();



        }

        private void UcitajDGVUtakmice()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            List<Utakmica> listau = new List<Utakmica>();

            foreach (MongoDBRef utakmicaRef in L.Utakmice.ToList())
            {
                Utakmica u = db.FetchDBRefAs<Utakmica>(utakmicaRef);
                listau.Add(u);
            }

            listau.Sort((x, y) => x.Datum.CompareTo(y.Datum));

            dataGridViewUtakmice.DataSource = listau;
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
            //dataGridViewTabela.Columns["Igraci"].Visible = false;
            //dataGridViewTabela.Columns["Utakmice"].Visible = false;
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
            FormUtakmica uform = new FormUtakmica();
            Utakmica ut = dataGridViewUtakmice.CurrentRow.DataBoundItem as Utakmica;
            uform.U = ut;
            uform.ShowDialog();
            UcitajDGVUtakmice();
        }
    }
}
