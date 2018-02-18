﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

namespace Mongo_Fudbal
{
    public class Liga
    {

        public ObjectId Id { get; set; }
        public string Ime { get; set; }
        public string Drzava { get; set; }
        public List<MongoDBRef> Klubovi { get; set; }
        public List<MongoDBRef> Utakmice { get; set; }

        public Liga()
        {
            Klubovi = new List<MongoDBRef>();
            Utakmice = new List<MongoDBRef>();

        }

    }
}
