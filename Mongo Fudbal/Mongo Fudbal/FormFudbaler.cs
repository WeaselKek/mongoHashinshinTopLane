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
    public partial class FormFudbaler : Form
    {
        public FormFudbaler()
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


            Fudbaler fd = new Fudbaler { Ime = txbIme.Text, Prezime = txbPrez.Text, Drzava = txbDrzava.Text, God_rodj = Int32.Parse(txbGod.Text) };

            igraciColl.Insert(fd);
            this.Close();
            
        }
    }
}
