using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using Mongo_Fudbal.Funkcije;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using System.Drawing;

namespace Mongo_Fudbal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ucitajDGV()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var collection = db.GetCollection<Liga>("lige");

            List<Liga> lista = new List<Liga>(collection.FindAll().SetSortOrder(SortBy.Ascending("Drzava")));
            dataGridView1.DataSource = lista;
            dataGridView1.Columns["id"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");
            var collection = db.GetCollection<Liga>("lige");

            Liga jsl = new Liga { Ime = "Srpska liga", Drzava = "Srbija"};


            collection.Insert(jsl);


            foreach (Liga lg in collection.FindAll())
            {
                MessageBox.Show(lg.Ime);
            }
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajLigu dlform = new DodajLigu();
            dlform.ShowDialog();
            ucitajDGV();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucitajDGV();
            btnUpdate.BackgroundImage = Image.FromFile("../../icons/edit.png");
            btnUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.BackgroundImage = Image.FromFile("../../icons/delete.png");
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Image.FromFile("../../slike/pozadina.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }


        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dataGridView1))
                return;

            Liga l = dataGridView1.CurrentRow.DataBoundItem as Liga;
            FormLiga lform = new FormLiga();
            lform.L = l;
            lform.ShowDialog();
            ucitajDGV();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dataGridView1))
                return;

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var collection = db.GetCollection<Liga>("lige");

            Liga l = dataGridView1.CurrentRow.DataBoundItem as Liga;
            if (l.Klubovi.Count > 0 || l.Utakmice.Count > 0)
            {
                MessageBox.Show("Ne moze da se obrise liga koja sadrzi klubove i utakmice");
                return;
            }
            else
            {
                collection.Remove(Query.EQ("_id", l.Id));
                MessageBox.Show("Liga je obrisana");
                ucitajDGV();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dataGridView1))
                return;

            Liga l = dataGridView1.CurrentRow.DataBoundItem as Liga;

            DodajLigu lform = new DodajLigu();
            lform.UpdateItem = l;
            lform.ShowDialog();
            ucitajDGV();
        }
    }
}
