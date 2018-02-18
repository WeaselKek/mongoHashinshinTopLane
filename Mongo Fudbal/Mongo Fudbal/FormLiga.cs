using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver.Builders;

namespace Mongo_Fudbal
{
    public partial class FormLiga : Form
    {
        public string Id { get; set; }

        public FormLiga()
        {
            InitializeComponent();
        }

        public FormLiga(string id)
        {
            this.Id = id;
        }

        private void FormLiga_Load(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("fudbal");
            var collection = db.GetCollection<Liga>("lige");

            var query = Query.EQ("id", this.Id);

        }
    }
}
