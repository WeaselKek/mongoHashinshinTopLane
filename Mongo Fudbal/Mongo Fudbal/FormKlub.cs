﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mongo_Fudbal.Funkcije;

namespace Mongo_Fudbal
{
    public partial class FormKlub : Form
    {
        public Klub K { get; set; }

        public FormKlub()
        {
            InitializeComponent();
        }


        private void UcitajDGVIgraci()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            List<Fudbaler> listaf = new List<Fudbaler>();

            foreach (MongoDBRef fudbalerRef in K.Igraci.ToList())
            {
                Fudbaler f = db.FetchDBRefAs<Fudbaler>(fudbalerRef);
                listaf.Add(f);
            }           

            dataGridViewIgraci.DataSource = listaf;

            dataGridViewIgraci.Columns["id"].Visible = false;
            dataGridViewIgraci.Columns["Klub"].Visible = false;
            dataGridViewIgraci.Columns["God_rodj"].Visible = false;
            dataGridViewIgraci.Columns["Broj_gol"].Visible = false;
            if (dataGridViewIgraci.Columns.Contains("Slika"))
            {
                dataGridViewIgraci.Columns["Slika"].Visible = false;
            }


        }

        private void FormKlub_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("../../slike/pozadina4.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            btnUpdate.BackgroundImage = Image.FromFile("../../icons/edit.png");
            btnUpdate.BackgroundImageLayout = ImageLayout.Stretch;

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            this.Text = K.Ime;
            lblNaziv.Text = K.Ime;
            lblGrad.Text = K.Grad;
            lblGodina.Text = K.God_osn.ToString();

            if (!String.IsNullOrEmpty(K.Slika))
            {
                pictureBox1.ImageLocation = K.Slika;
            }

            Liga l = db.FetchDBRefAs<Liga>(K.Liga);

            lblLiga.Text = l.Ime + " (" + l.Drzava + ")";

            UcitajDGVIgraci();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajFudbalera formdf = new DodajFudbalera();
            formdf.K = this.K;
            formdf.ShowDialog();
            UcitajDGVIgraci();
        }

        private void btnVidi_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dataGridViewIgraci))
                return;

            FormFudbaler duform = new FormFudbaler();
            duform.F = dataGridViewIgraci.CurrentRow.DataBoundItem as Fudbaler;
            duform.ShowDialog();
            UcitajDGVIgraci();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Provera.chkIfSelected(dataGridViewIgraci))
                return;
            DodajFudbalera duform = new DodajFudbalera();
            duform.UpdateItem = dataGridViewIgraci.CurrentRow.DataBoundItem as Fudbaler;
            duform.ShowDialog();
            UcitajDGVIgraci();
        }
    }
}
