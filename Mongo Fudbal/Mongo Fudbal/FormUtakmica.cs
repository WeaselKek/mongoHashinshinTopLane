using MongoDB.Driver;
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
    public partial class FormUtakmica : Form
    {
        public Utakmica U { get; set; }

        public FormUtakmica()
        {
            InitializeComponent();
        }

        private void UcitajListBoxDogadjaji()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            List<Dogadjaj> listad = new List<Dogadjaj>();

            foreach (MongoDBRef dogRef in U.Dogadjaji.ToList())
            {
                Dogadjaj d = db.FetchDBRefAs<Dogadjaj>(dogRef);
                listad.Add(d);
            }

            listad.Sort((x, y) => x.Minut.CompareTo(y.Minut));

            

            foreach (Dogadjaj d in listad)
            {
                MongoDBRef fRef = new MongoDBRef("igraci", d.Igrac.Id);
                Fudbaler f = db.FetchDBRefAs<Fudbaler>(fRef);
                String s = d.Minut + "'  " + d.Tip + "   " + f.Ime + " " + f.Prezime;
                listBoxDogadjaji.Items.Add(s);
            }

        }

        private void FormUtakmica_Load(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            Klub klub1 = db.FetchDBRefAs<Klub>(U.Klub1);
            Klub klub2 = db.FetchDBRefAs<Klub>(U.Klub2);

            this.Text = klub1.Ime + " - " + klub2.Ime;
            lblDatum.Text = "(" + U.Datum.ToString() + ")";
            lblDomacin.Text = klub1.Ime;
            lblGost.Text = klub2.Ime;
            lblRezultat.Text = U.Rezultat;
            lblStadion.Text = "Stadion: " + klub1.Stadion;

            UcitajListBoxDogadjaji();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajDogadjaj ddform = new DodajDogadjaj();
            ddform.U = this.U;
            ddform.ShowDialog();
            UcitajListBoxDogadjaji();

        }
    }
}
