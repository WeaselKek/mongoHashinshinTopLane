using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MongoDB.Bson;
using MongoDB.Driver;

namespace Mongo_Fudbal
{
    public class Klub
    {
        public ObjectId Id { get; set; }
        public string Ime { get; set; }
        public int God_osn { get; set; }
        public string Grad { get; set; }
        public int Bodovi { get; set; }
        public string Stadion { get; set; }
        public string Slika { get; set; }
        public MongoDBRef Liga { get; set; }
        public List<MongoDBRef> Igraci { get; set; }
        public List<MongoDBRef> Utakmice { get; set; }


        public Klub()
        {
            Igraci = new List<MongoDBRef>();
            Utakmice = new List<MongoDBRef>();
        }

    }
}
