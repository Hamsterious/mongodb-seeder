using MongoDB.Bson;
using MongoDB.Driver;
using MongoSeeder.Models;
using System;
using System.Xml;

namespace MongoSeeder
{
    class Program
    {
        static void Main(string[] args)
        {
            SeedStationTemperature();
        }

        static void SeedMercury()
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase db = client.GetDatabase("Meteorologi");
            IMongoCollection<Mercury> mercuryCollection = db.GetCollection<Mercury>("mercury");

            var counter = 0;

            Mercury mercury = new Mercury();

            /// READ XML
            XmlReader xmlReader = XmlReader.Create(@"C:\Users\marti\Desktop\School\AirData\Data\Mercury.xml");
            while (xmlReader.Read())
            {
                // Read node
                if ((xmlReader.NodeType == XmlNodeType.Element))
                {

                    if (mercury.DateTimeStart != null && mercury.Hg != 0 && !String.IsNullOrEmpty(mercury.Unit))
                    {
                        mercuryCollection.InsertOne(mercury);
                        mercury = new Mercury();
                        //Console.WriteLine("new created");
                    }

                    if (xmlReader.Name.Equals("DateTimeStart"))
                    {
                        mercury.DateTimeStart = DateTime.Parse(xmlReader.ReadElementContentAsString());
                        //Console.WriteLine("DateTimeStart read");
                    }

                    if (xmlReader.Name.Equals("Hg"))
                    {
                        mercury.Hg = double.Parse(xmlReader.ReadElementContentAsString());
                        //Console.WriteLine("Hg read");
                    }

                    if (xmlReader.Name.Equals("unit"))
                    {
                        mercury.Unit = xmlReader.ReadElementContentAsString();
                        //Console.WriteLine("unit read");
                    }
                    //Console.WriteLine(mercury);


                    // Insert into DB
                    Console.WriteLine("So far: " + counter++);
                }
            }
            mercuryCollection.InsertOne(mercury);
            Console.WriteLine("Done");
            Console.ReadKey();
        }

        static void SeedMeteorologi()
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase db = client.GetDatabase("Meteorologi");
            IMongoCollection<Meteorologi> meteorologiCollection = db.GetCollection<Meteorologi>("meteorologi");

            var counter = 0;

            Meteorologi meteorologi = new Meteorologi();

            /// READ XML
            XmlReader xmlReader = XmlReader.Create(@"C:\Users\marti\Desktop\School\AirData\Data\Meteorologi.xml");
            while (xmlReader.Read())
            {
                // Read node
                if ((xmlReader.NodeType == XmlNodeType.Element))
                {

                    if (meteorologi.StartDateTime != null &&
                        meteorologi.WindDirection != 0 &&
                        meteorologi.WindSpeed != 0 &&
                        meteorologi.Temperature != 0 &&
                        meteorologi.Humidity != 0 &&
                        meteorologi.Radiation != 0 &&
                        meteorologi.Pressure != 0
                        )
                    {
                        meteorologiCollection.InsertOne(meteorologi);
                        meteorologi = new Meteorologi();
                    }

                    if (xmlReader.Name.Equals("StartDateTime"))
                    {
                        meteorologi.StartDateTime = DateTime.Parse(xmlReader.ReadElementContentAsString());
                    }

                    if (xmlReader.Name.Equals("WindDirection"))
                    {
                        meteorologi.WindDirection = double.Parse(xmlReader.ReadElementContentAsString());
                    }

                    if (xmlReader.Name.Equals("WindSpeed"))
                    {
                        meteorologi.WindSpeed = double.Parse(xmlReader.ReadElementContentAsString());
                    }
                    if (xmlReader.Name.Equals("Temperature"))
                    {
                        meteorologi.Temperature = double.Parse(xmlReader.ReadElementContentAsString());
                    }
                    if (xmlReader.Name.Equals("Humidity"))
                    {
                        meteorologi.Humidity = double.Parse(xmlReader.ReadElementContentAsString());
                    }
                    if (xmlReader.Name.Equals("Radiation"))
                    {
                        meteorologi.Radiation = double.Parse(xmlReader.ReadElementContentAsString());
                    }
                    if (xmlReader.Name.Equals("Pressure"))
                    {
                        meteorologi.Pressure = double.Parse(xmlReader.ReadElementContentAsString());
                    }

                    Console.WriteLine("So far: " + counter++);
                }
            }
            meteorologiCollection.InsertOne(meteorologi);
            Console.WriteLine("Done");
            Console.ReadKey();
        }

        static void SeedOzone()
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase db = client.GetDatabase("Meteorologi");
            IMongoCollection<Ozone> ozoneCollection = db.GetCollection<Ozone>("ozone");

            var counter = 0;

            Ozone ozone = new Ozone();

            /// READ XML
            XmlReader xmlReader = XmlReader.Create(@"C:\Users\marti\Desktop\School\AirData\Data\Ozone.xml");
            while (xmlReader.Read())
            {
                // Read node
                if ((xmlReader.NodeType == XmlNodeType.Element))
                {

                    if (ozone.DateTimeStart != null && ozone.Oz != 0 && !String.IsNullOrEmpty(ozone.Unit))
                    {
                        ozoneCollection.InsertOne(ozone);
                        ozone = new Ozone();
                        //Console.WriteLine("new created");
                    }

                    if (xmlReader.Name.Equals("DateTimeStart"))
                    {
                        ozone.DateTimeStart = DateTime.Parse(xmlReader.ReadElementContentAsString());
                        //Console.WriteLine("DateTimeStart read");
                    }

                    if (xmlReader.Name.Equals("Ozone"))
                    {
                        ozone.Oz = double.Parse(xmlReader.ReadElementContentAsString());
                        //Console.WriteLine("Hg read");
                    }

                    if (xmlReader.Name.Equals("unit"))
                    {
                        ozone.Unit = xmlReader.ReadElementContentAsString();
                        //Console.WriteLine("unit read");
                    }
                    //Console.WriteLine(ozone);


                    // Insert into DB
                    Console.WriteLine("So far: " + counter++);
                }
            }
            ozoneCollection.InsertOne(ozone);
            Console.WriteLine("Done");
            Console.ReadKey();
        }

        static void SeedPrecipitation()
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase db = client.GetDatabase("Meteorologi");
            IMongoCollection<Precipitation> precipitationCollection = db.GetCollection<Precipitation>("precipitation");

            var counter = 0;

            Precipitation precipitation = new Precipitation();

            /// READ XML
            XmlReader xmlReader = XmlReader.Create(@"C:\Users\marti\Desktop\School\AirData\Data\precipitation.xml");
            while (xmlReader.Read())
            {
                // Read node
                if ((xmlReader.NodeType == XmlNodeType.Element))
                {

                    if (precipitation.DateTimeStart != null && precipitation.Prep_Hour != null && precipitation.Prep_Tot != null)
                    {
                        precipitationCollection.InsertOne(precipitation);
                        precipitation = new Precipitation();
                        //Console.WriteLine("new created");
                    }

                    if (xmlReader.Name.Equals("DateTimeStart"))
                    {
                        precipitation.DateTimeStart = DateTime.Parse(xmlReader.ReadElementContentAsString());
                        //Console.WriteLine("DateTimeStart read");
                    }

                    if (xmlReader.Name.Equals("Prep_Hour"))
                    {
                        precipitation.Prep_Hour = double.Parse(xmlReader.ReadElementContentAsString());
                        //Console.WriteLine("Hg read");
                    }

                    if (xmlReader.Name.Equals("Prep_Tot"))
                    {
                        precipitation.Prep_Tot = double.Parse(xmlReader.ReadElementContentAsString());
                        //Console.WriteLine("unit read");
                    }
                    //Console.WriteLine(ozone);


                    // Insert into DB
                    Console.WriteLine("So far: " + counter++);
                }
            }
            precipitationCollection.InsertOne(precipitation);
            Console.WriteLine("Done");
            Console.ReadKey();
        }

        static void SeedStationTemperature()
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase db = client.GetDatabase("Meteorologi");
            IMongoCollection<StationTemperature> stationTemperatureCollection = db.GetCollection<StationTemperature>("precipitation");

            var counter = 0;

            StationTemperature precipitation = new StationTemperature();

            /// READ XML
            XmlReader xmlReader = XmlReader.Create(@"C:\Users\marti\Desktop\School\AirData\Data\StationTemperature.xml");
            while (xmlReader.Read())
            {
                // Read node
                if ((xmlReader.NodeType == XmlNodeType.Element))
                {

                    if (precipitation.DateTimeStart != null && precipitation.T != null && precipitation.RH != null)
                    {
                        stationTemperatureCollection.InsertOne(precipitation);
                        precipitation = new StationTemperature();
                        //Console.WriteLine("new created");
                    }

                    if (xmlReader.Name.Equals("DateTimeStart"))
                    {
                        precipitation.DateTimeStart = DateTime.Parse(xmlReader.ReadElementContentAsString());
                        //Console.WriteLine("DateTimeStart read");
                    }

                    if (xmlReader.Name.Equals("T"))
                    {
                        precipitation.T = double.Parse(xmlReader.ReadElementContentAsString());
                        //Console.WriteLine("Hg read");
                    }

                    if (xmlReader.Name.Equals("RH"))
                    {
                        precipitation.RH = double.Parse(xmlReader.ReadElementContentAsString());
                        //Console.WriteLine("unit read");
                    }
                    //Console.WriteLine(ozone);


                    // Insert into DB
                    Console.WriteLine("So far: " + counter++);
                }
            }
            stationTemperatureCollection.InsertOne(precipitation);
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}