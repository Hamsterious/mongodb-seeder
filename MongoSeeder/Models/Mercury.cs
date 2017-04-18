using System;
using System.Collections.Generic;
using System.Text;

namespace MongoSeeder.Models
{
    class Mercury
    {
        public ObjectId Id { get; set; }
        public DateTime? DateTimeStart { get; set; }
        public double Hg { get; set; }
        public string Unit { get; set; }

        override public string ToString()
        {
            return $"DateTimeStart: {DateTimeStart}, Hg: {Hg}, Unit: {Unit}";
        }
    }
}
