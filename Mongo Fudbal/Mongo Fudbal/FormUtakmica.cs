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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajDogadjaj ddform = new DodajDogadjaj();
            ddform.U = this.U;
            ddform.ShowDialog();

        }
    }
}
