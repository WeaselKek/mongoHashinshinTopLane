﻿using System;
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
        public DodajUtakmicu()
        {
            InitializeComponent();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");

            var utakmiceColl = db.GetCollection<Utakmica>("utakmice");
            var kluboviColl = db.GetCollection<Klub>("klubovi");

            Klub home = (from klubovi in kluboviColl.AsQueryable<Klub>()
                         where klubovi.Ime == cbxH.Text
                         select klubovi).Single();

            Klub away = (from klubovi in kluboviColl.AsQueryable<Klub>()
                         where klubovi.Ime == cbxH.Text
                         select klubovi).Single();

            MongoDBRef pom1 = new MongoDBRef("klubovi", home.Id);
            MongoDBRef pom2 = new MongoDBRef("klubovi", home.Id);

            Utakmica ut = new Utakmica { Datum = dtp1.Value, Rezultat = golH + ":" + golA, Klub1 = pom1, Klub2 = pom2 };


            utakmiceColl.Insert(ut);
            this.Close();
        }
    }
}
