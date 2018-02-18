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

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            //db.CreateCollection("preduzece");

            var collection = db.GetCollection<Liga>("lige");

            Liga jsl = new Liga { Ime = "Srpska liga", Drzava = "Srbija"};


            collection.Insert(jsl);


            foreach (Liga lg in collection.FindAll())
            {
                MessageBox.Show(lg.Ime);
            }
        }
    }
}
