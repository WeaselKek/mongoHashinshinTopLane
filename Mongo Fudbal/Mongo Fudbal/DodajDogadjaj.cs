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
    public partial class DodajDogadjaj : Form
    {

        public Utakmica U { get; set; }

        public DodajDogadjaj()
        {
            InitializeComponent();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var utakmiceColl = db.GetCollection<Utakmica>("dogadjaji");
            var igraciColl = db.GetCollection<Fudbaler>("igraci");

            Fudbaler home = (from igraci in igraciColl.AsQueryable<Fudbaler>()
                             where igraci.Ime == cbxIgrac.Text
                             select igraci).Single();



            MongoDBRef pom1 = new MongoDBRef("igraci", home.Id);


            Dogadjaj dog = new Dogadjaj { Minut = Int32.Parse(txtMinut.Text), Tip = cbxTip.Text, Igrac=pom1 };


            igraciColl.Insert(dog);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
