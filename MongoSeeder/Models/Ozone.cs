using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoSeeder.Models
{
    class Ozone
    {
        public ObjectId Id { get; set; }
        public DateTime? DateTimeStart { get; set; }
        public double Oz { get; set; }
        public string Unit { get; set; }

        override public string ToString()
        {
            return $"DateTimeStart: {DateTimeStart}, Hg: {Oz}, Unit: {Unit}";
        }
    }
}
