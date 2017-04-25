using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoSeeder.Models
{
    class StationTemperature
    {
        public ObjectId Id { get; set; }
        public DateTime? DateTimeStart { get; set; }
        public double? T { get; set; }
        public double? RH { get; set; }
    }
}
