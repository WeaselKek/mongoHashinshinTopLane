using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mongo_Fudbal
{
    public partial class DodajKlub : Form
    {
        public Liga L { get; set; }

        public DodajKlub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var kluboviColl = db.GetCollection<Klub>("klubovi");
            var ligeColl = db.GetCollection<Liga>("lige");


            MongoDBRef liga1 = new MongoDBRef("lige", L.Id);

            Klub klub = new Klub { Ime = txtNaziv.Text, Grad = txtGrad.Text, Bodovi = 0, Stadion = txtStadion.Text, God_osn = Int32.Parse(txtGodina.Text), Liga = liga1 };

            kluboviColl.Insert(klub);

            MongoDBRef klub1 = new MongoDBRef("klubovi", klub.Id);

            L.Klubovi.Add(klub1);
            ligeColl.Save(L);

            this.Close();
        }
    }
}
