using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;


namespace Mongo_Fudbal
{
    public class Dogadjaj
    {
        public ObjectId Id { get; set; }
        public int Minut { get; set; }
        public string Tip { get; set; }
        public MongoDBRef Utakmica { get; set; }
        public MongoDBRef Igrac { get; set; }

    }
}
