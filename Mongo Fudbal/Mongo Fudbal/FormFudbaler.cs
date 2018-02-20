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
        public Fudbaler F { get; set; }
        public FormFudbaler()
        {
            InitializeComponent();
        }

        private void FormFudbaler_Load(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");
            
            this.Text = F.Ime+" "+F.Prezime;
            lblIme.Text = F.Ime + " " + F.Prezime;
            lblDrz.Text = F.Drzava;
            lblGod.Text=F.God_rodj.ToString();
            lblGolovi.Text = F.Broj_gol.ToString();

            Klub kl = db.FetchDBRefAs<Klub>(F.Klub);

            lblKlub.Text = kl.Ime;

            if (!String.IsNullOrEmpty(F.Slika))
            {
                pictureBox1.ImageLocation = F.Slika;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var igraciColl = db.GetCollection<Fudbaler>("igraci");

            //F.Broj_gol = Int32.Parse(txtGol.Text);
            //igraciColl.Save(F);
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
