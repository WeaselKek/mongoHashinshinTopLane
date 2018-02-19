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
    public partial class DodajUtakmicu : Form
    {
        public Liga L { get; set; }

        public DodajUtakmicu()
        {
            InitializeComponent();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            //validacija
            if ((cbxH.Text == "") || (cbxA.Text == "") || (golH.Text == "") || (golA.Text == ""))
            {
                MessageBox.Show("Niste uneli sva potrebna polja");
                return;
            }

             if (cbxH.Text ==cbxA.Text )
             {
                 MessageBox.Show("Izaberiite dva razlicita kluba");
                 return;
             }




            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var utakmiceColl = db.GetCollection<Utakmica>("utakmice");
            var kluboviColl = db.GetCollection<Klub>("klubovi");
            var ligeColl = db.GetCollection<Liga>("lige");

            Klub home = (from klubovi in kluboviColl.AsQueryable<Klub>()
                         where klubovi.Ime == cbxH.Text
                         select klubovi).Single();

            Klub away = (from klubovi in kluboviColl.AsQueryable<Klub>()
                         where klubovi.Ime == cbxA.Text
                         select klubovi).Single();

            MongoDBRef homeref = new MongoDBRef("klubovi", home.Id);
            MongoDBRef awayref = new MongoDBRef("klubovi", away.Id);
            MongoDBRef liga1 = new MongoDBRef("lige", L.Id);

            Utakmica ut = new Utakmica { Datum = dtp1.Value, Rezultat = golH.Text + ":" + golA.Text, Klub1 = homeref, Klub2 = awayref, Liga = liga1 };
            utakmiceColl.Insert(ut);

            L.Utakmice.Add(new MongoDBRef("utakmice", ut.Id));
            ligeColl.Save(L);

            //dodavanje poena klubovima

            Klub homek = db.FetchDBRefAs<Klub>(homeref);
            Klub awayk = db.FetchDBRefAs<Klub>(awayref);

            homek.Utakmice.Add(new MongoDBRef("utakmice", ut.Id));
            awayk.Utakmice.Add(new MongoDBRef("utakmice", ut.Id));

            if (Int32.Parse(golH.Text) > Int32.Parse(golA.Text))
            {
                homek.Bodovi += 3;
            }
            else if (Int32.Parse(golH.Text) == Int32.Parse(golA.Text))
            {
                homek.Bodovi += 1;
                awayk.Bodovi += 1;
            }
            else
            {
                awayk.Bodovi += 3;
            }

            kluboviColl.Save(homek);
            kluboviColl.Save(awayk);

            this.Close();
        }


        private void DodajUtakmicu_Load(object sender, EventArgs e)
        {

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            List<String> listak = new List<String>();

            foreach (MongoDBRef klubRef in L.Klubovi.ToList())
            {
                Klub klub = db.FetchDBRefAs<Klub>(klubRef);
                cbxH.Items.Add(klub.Ime);
                cbxA.Items.Add(klub.Ime);
            }          
        }

        private void golH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void golA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
