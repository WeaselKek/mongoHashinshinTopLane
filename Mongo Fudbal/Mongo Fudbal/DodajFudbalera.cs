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
    public partial class DodajFudbalera : Form
    {
        public Klub K { get; set; }
        public DodajFudbalera()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var igraciColl = db.GetCollection<Utakmica>("igraci");
            var kluboviColl = db.GetCollection<Klub>("klubovi");

            MongoDBRef pom1 = new MongoDBRef("klubovi", K.Id);

            Fudbaler fd = new Fudbaler { Ime = txbIme.Text, Prezime = txbPrez.Text, Drzava = txbDrzava.Text, God_rodj = Int32.Parse(txbGod.Text),
                                         Klub=pom1,Broj_gol=Int32.Parse(txbGol.Text) };



            igraciColl.Insert(fd);

            K.Igraci.Add(pom1);
            kluboviColl.Save(K);
            this.Close();
            
        }
    }
}
