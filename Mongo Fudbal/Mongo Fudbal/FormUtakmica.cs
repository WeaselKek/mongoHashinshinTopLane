using MongoDB.Driver;
using MongoDB.Driver.Builders;
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

        private void UcitajDGVDogadjaji()
        {
            dataGridViewDogadjaji.Rows.Clear();
            dataGridViewDogadjaji.Refresh();

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
                Fudbaler f = db.FetchDBRefAs<Fudbaler>(d.Igrac);
                var index = dataGridViewDogadjaji.Rows.Add();
                dataGridViewDogadjaji.Rows[index].Cells[0].Value = d.Minut + "' " + d.Tip + "   " + f.ToString();
                dataGridViewDogadjaji.Rows[index].Tag = d;
            }

        }

        private void FormUtakmica_Load(object sender, EventArgs e)
        {
            btnDelete.BackgroundImage = Image.FromFile("../../icons/delete.png");
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;

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


            dataGridViewDogadjaji.ColumnCount = 1;
            dataGridViewDogadjaji.Columns[0].Name = "";

            UcitajDGVDogadjaji();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajDogadjaj ddform = new DodajDogadjaj();
            ddform.U = this.U;
            ddform.ShowDialog();
            UcitajDGVDogadjaji();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var utakmiceColl = db.GetCollection<Utakmica>("utakmice");
            var dogadjajiColl = db.GetCollection<Dogadjaj>("dogadjaji");

            Dogadjaj d = dataGridViewDogadjaji.CurrentRow.Tag as Dogadjaj;
            MongoDBRef mdbref = new MongoDBRef("dogadjaji", d.Id);
            U.Dogadjaji.Remove(mdbref);

            utakmiceColl.Save(U);

            dogadjajiColl.Remove(Query.EQ("_iq", d.Id));

            UcitajDGVDogadjaji();

        }
    }
}
