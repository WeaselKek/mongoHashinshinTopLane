using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

namespace Mongo_Fudbal
{
    public class Fudbaler
    {

        public ObjectId Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int God_rodj { get; set; }
        public string Drzava { get; set; }
        public MongoDBRef Klub { get; set; }
        public int Broj_gol { get; set; }
    }
}
