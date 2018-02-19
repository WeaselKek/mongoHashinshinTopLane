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
            //validacija
            if ((txtMinut.Text == "") || (cbxTip.Text == "") || (cbxIgrac.Text == ""))
            {
                MessageBox.Show("Niste uneli sva potrebna polja");
                return;
            }

            int minuti = Int32.Parse(txtMinut.Text);
            if (minuti<1 || minuti>100)
            {
                MessageBox.Show("Nevalidan minut");
                return;
            }

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var utakmiceColl = db.GetCollection<Utakmica>("utakmice");
            var igraciColl = db.GetCollection<Fudbaler>("igraci");
            var dogadjajiColl = db.GetCollection<Dogadjaj>("dogadjaji");

            Fudbaler igrac = cbxIgrac.SelectedItem as Fudbaler;

            MongoDBRef pom1 = new MongoDBRef("igraci", igrac.Id);
            MongoDBRef pom2 = new MongoDBRef("utakmice", U.Id);

            Dogadjaj dog = new Dogadjaj { Minut = minuti, Tip = cbxTip.Text, Igrac=pom1,Utakmica=pom2 };
            dogadjajiColl.Insert(dog);

            U.Dogadjaji.Add(new MongoDBRef("dogadjaji", dog.Id));
            utakmiceColl.Save(U);

            if (cbxTip.Text == "Gol")
            {
                igrac.Broj_gol += 1;
                igraciColl.Save(igrac);
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajDogadjaj_Load(object sender, EventArgs e)
        {



            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");
            var utakmiceColl = db.GetCollection<Utakmica>("utakmice");
            var igraciColl = db.GetCollection<Fudbaler>("igraci");
            var dogadjajiColl = db.GetCollection<Dogadjaj>("dogadjaji");
            

            var query1 = from fudbaler in igraciColl.AsQueryable<Fudbaler>()
                         where fudbaler.Klub.Id == U.Klub1.Id
                         select fudbaler;

            MongoDBRef kref1 = new MongoDBRef("klubovi", U.Klub1.Id);
            Klub k1 = db.FetchDBRefAs<Klub>(kref1);

            foreach (Fudbaler f in query1)
            {
                cbxIgrac.Items.Add(f);
            }

            var query2 = from fudbaler in igraciColl.AsQueryable<Fudbaler>()
                         where fudbaler.Klub.Id == U.Klub2.Id
                         select fudbaler;

            MongoDBRef kref2 = new MongoDBRef("klubovi", U.Klub2.Id);
            Klub k2 = db.FetchDBRefAs<Klub>(kref2);

            foreach (Fudbaler f in query2)
            {               
                cbxIgrac.Items.Add(f);
            }
        }

        private void txtMinut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
