using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mongo_Fudbal
{
    public partial class DodajKlub : Form
    {
        public Liga L { get; set; }

        public DodajKlub()
        {
            InitializeComponent();
        }

        private string upload_image(Klub klub)
        {
            if (String.IsNullOrEmpty(openFileDialog1.FileName))
            {
                return null;
            }
                    
            string sourceFile = openFileDialog1.FileName;
            string targetPath = "../../slike/Klubovi";

            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            string fileName = klub.Id.ToString() + Path.GetExtension(openFileDialog1.FileName);

            string destFile = System.IO.Path.Combine(targetPath, fileName);

            System.IO.File.Copy(sourceFile, destFile, true);

            return destFile;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validacija
            if ((txtNaziv.Text == "") || (txtGrad.Text == "") || (txtStadion.Text == "") || (txtGodina.Text == ""))
            {
                MessageBox.Show("Niste uneli sva potrebna polja");
                return;
            }


            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var kluboviColl = db.GetCollection<Klub>("klubovi");
            var ligeColl = db.GetCollection<Liga>("lige");


            MongoDBRef liga1 = new MongoDBRef("lige", L.Id);

            Klub klub = new Klub { Ime = txtNaziv.Text, Grad = txtGrad.Text, Bodovi = 0, Stadion = txtStadion.Text, God_osn = Int32.Parse(txtGodina.Text), Liga = liga1 };  
          
            kluboviColl.Insert(klub);

            klub.Slika = upload_image(klub);

            kluboviColl.Save(klub);


            MongoDBRef klub1 = new MongoDBRef("klubovi", klub.Id);

            L.Klubovi.Add(klub1);
            ligeColl.Save(L);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void DodajKlub_Load(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
        }

        private void txtGodina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
