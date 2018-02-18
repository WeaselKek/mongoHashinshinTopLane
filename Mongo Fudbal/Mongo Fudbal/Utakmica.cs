using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MongoDB.Bson;
using MongoDB.Driver;

namespace Mongo_Fudbal
{
    class Utakmica
    {
        public ObjectId Id { get; set; }
        public DateTime Datum { get; set; }
        public string Rezultat { get; set; }
        public MongoDBRef Liga { get; set; }
        public MongoDBRef Klub1 { get; set; }
        public MongoDBRef Klub2 { get; set; }
        public List<MongoDBRef> Dogadjaji { get; set; }

        public Utakmica()
        {
            Dogadjaji = new List<MongoDBRef>();
        }

    }
}
