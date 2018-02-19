using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

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
        }


        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            Liga l = dataGridView1.CurrentRow.DataBoundItem as Liga;
            FormLiga lform = new FormLiga();
            lform.L = l;
            lform.ShowDialog();
            ucitajDGV();

        }
    }
}
