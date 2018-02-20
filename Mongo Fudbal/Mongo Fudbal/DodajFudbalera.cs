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
using System.IO;

namespace Mongo_Fudbal
{
    public partial class DodajFudbalera : Form
    {
        public Klub K { get; set; }
        public Fudbaler UpdateItem { get; set; }
        public DodajFudbalera()
        {
            InitializeComponent();
        }

        private string upload_image(Fudbaler f)
        {
            if (String.IsNullOrEmpty(openFileDialog1.FileName))
            {
                return null;
            }

            string sourceFile = openFileDialog1.FileName;
            string targetPath = "../../slike/Fudbaleri";

            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            string fileName = f.Id.ToString() + Path.GetExtension(openFileDialog1.FileName);

            string destFile = System.IO.Path.Combine(targetPath, fileName);

            System.IO.File.Copy(sourceFile, destFile, true);

            return destFile;
        }


        private void btnTrue_Click(object sender, EventArgs e)
        {
            //validacija
            if ((txbIme.Text == "") || (txbPrez.Text == "") || (txbDrzava.Text == "") || (txbGod.Text == ""))
            {
                MessageBox.Show("Niste uneli sva potrebna polja");
                return;
            }

            if (UpdateItem != null)
            {
                Azuriraj();
                return;
            }

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var igraciColl = db.GetCollection<Fudbaler>("igraci");
            var kluboviColl = db.GetCollection<Klub>("klubovi");

            MongoDBRef pom1 = new MongoDBRef("klubovi", K.Id);

            Fudbaler fd = new Fudbaler { Ime = txbIme.Text, Prezime = txbPrez.Text, Drzava = txbDrzava.Text, God_rodj = Int32.Parse(txbGod.Text),
                                         Klub=pom1, Broj_gol = 0 };
            igraciColl.Insert(fd);

            fd.Slika = upload_image(fd);

            igraciColl.Save(fd);

            

            K.Igraci.Add(new MongoDBRef("igraci", fd.Id));
            kluboviColl.Save(K);
            this.Close();
            
        }

        private void Azuriraj()
        {

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var collection = db.GetCollection<Fudbaler>("igraci");



            var query = Query.EQ("_id", UpdateItem.Id);
            Fudbaler fu = collection.Find(query).Single();


            fu.Ime = txbIme.Text;
            fu.Prezime = txbPrez.Text;
            fu.Drzava = txbDrzava.Text;
            fu.God_rodj = Int32.Parse(txbGod.Text);
            if (fu.Slika != lblSlika.Text)
            {
                fu.Slika = upload_image(fu);
            }

            collection.Save(fu);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblSlika.Text = openFileDialog1.FileName;
            }
            else if (result == DialogResult.Cancel)
            {
                openFileDialog1.FileName = "";
            }
        }

        private void DodajFudbalera_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("../../slike/pozadina2.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            if (UpdateItem != null)
            {
                btnTrue.Text = "Azuriraj";
                txbIme.Text = UpdateItem.Ime;
                txbPrez.Text = UpdateItem.Prezime;
                txbDrzava.Text = UpdateItem.Drzava;
                txbGod.Text = UpdateItem.God_rodj.ToString();
                lblSlika.Text = UpdateItem.Slika;
                return;
            }
            openFileDialog1.FileName = "";
        }

        private void txbGod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
