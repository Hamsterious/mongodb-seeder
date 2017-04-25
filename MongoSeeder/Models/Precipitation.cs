using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoSeeder.Models
{
    class Precipitation
    {
        public ObjectId Id { get; set; }
        public DateTime? DateTimeStart { get; set; }
        public double? Prep_Hour { get; set; }
        public double? Prep_Tot { get; set; }
    }
}
