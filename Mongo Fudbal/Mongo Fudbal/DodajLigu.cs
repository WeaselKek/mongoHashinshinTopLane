using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace Mongo_Fudbal
{
    public partial class DodajLigu : Form
    {
        

        public Liga UpdateItem
        {
            get;
            set;
        }
        public DodajLigu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //validacija
            if ((txtNaziv.Text == "") || (txtDrzava.Text == ""))
            {
                MessageBox.Show("Niste uneli sva potrebna polja");
                return;
            }

            if (UpdateItem != null)
            {
                Azuriraj();
                return;
            }

            string naziv = txtNaziv.Text;
            string drzava = txtDrzava.Text;

            if (String.IsNullOrEmpty(naziv) || String.IsNullOrEmpty(drzava))
            {
                return;
            }

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var collection = db.GetCollection<Liga>("lige");

            Liga liga = new Liga { Ime = naziv, Drzava = drzava };


            collection.Insert(liga);

            this.Close();
        }
        private void Azuriraj()
        {

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var collection = db.GetCollection<Liga>("lige");

            

            var query = Query.EQ("_id", UpdateItem.Id);
            Liga lg = collection.Find(query).Single();




            lg.Ime = txtNaziv.Text;
            lg.Drzava = txtDrzava.Text;

            collection.Save(lg);
            this.Close();
        }

        private void DodajLigu_Load(object sender, EventArgs e)
        {
            if (UpdateItem != null)
            {
                btnTrue.Text = "Azuriraj";
                txtNaziv.Text = UpdateItem.Ime;
                txtDrzava.Text = UpdateItem.Drzava;
            }
        }
    }
}
