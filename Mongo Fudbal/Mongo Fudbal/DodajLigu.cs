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
    }
}
