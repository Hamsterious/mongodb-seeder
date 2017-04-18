using System;
using System.Collections.Generic;
using System.Text;

namespace MongoSeeder.Models
{
    class Meteorologi
    {
        public ObjectId Id { get; set; }
        public DateTime? StartDateTime { get; set; }
        public double WindDirection { get; set; }
        public double WindSpeed { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double Radiation { get; set; }
        public double Pressure { get; set; }
    }
}
