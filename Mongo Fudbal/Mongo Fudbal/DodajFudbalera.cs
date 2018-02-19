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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var igraciColl = db.GetCollection<Fudbaler>("igraci");
            var kluboviColl = db.GetCollection<Klub>("klubovi");

            MongoDBRef pom1 = new MongoDBRef("klubovi", K.Id);

            Fudbaler fd = new Fudbaler { Ime = txbIme.Text, Prezime = txbPrez.Text, Drzava = txbDrzava.Text, God_rodj = Int32.Parse(txbGod.Text),
                                         Klub=pom1, Broj_gol = 0 };

            fd.Slika = upload_image(fd);

            igraciColl.Insert(fd);

            K.Igraci.Add(new MongoDBRef("igraci", fd.Id));
            kluboviColl.Save(K);
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
            openFileDialog1.FileName = "";
        }
    }
}
