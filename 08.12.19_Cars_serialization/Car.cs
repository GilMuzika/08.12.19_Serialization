using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _08._12._19_Cars_serialization
{
    public class Car
    {
        public static readonly string SAVING_DIR_NAME = "Serialized_Objects_Saved_Here";


        public string Brand { get; set; }
        public string Model {get; set;}
        public int Year { get; set; }
        public string Color { get; set; }

        private int _codan;
        protected int _numberOfSeats;

        static private XmlSerializer _serializer;
        private static string[] filenames;



        public Car(string model, string brand, int year, Color color, int codan, int numberOfSeats)
        {
            Model = model;
            Brand = brand;
            Year = year;
            this.Color = color.ToString();
            this._codan = codan;
            this._numberOfSeats = numberOfSeats;
        }
        public Car(string filenameAndPath)
        {
            var localCar = DeSerializeACar(filenameAndPath);
            this.Brand = localCar.Brand;
            this.Model = localCar.Model;
            this.Year = localCar.Year;
            this.Color = localCar.Color;
        }


        public Car() {}
        public int GetCoden()
        {
            return this._codan;
        }
        public int GetNumberOfSeats()
        {
            return this._numberOfSeats;
        }
        protected void ChangeNumberOfSeats(int numberOfSeats)
        {
            this._numberOfSeats = numberOfSeats;
        }

        public static void SerializeACar(Car car)
        {
            Directory.CreateDirectory(SAVING_DIR_NAME);
            _serializer = new XmlSerializer(typeof(Car));
            filenames = Directory.GetFiles(SAVING_DIR_NAME).Where(x => x.Contains("Car_")).ToArray();

            using (Stream fileStream = new FileStream(SAVING_DIR_NAME + @"\Car_"+ (filenames.Length + 1) +".xml", FileMode.Create))
            {
                _serializer.Serialize(fileStream, car);
            }
        }
        public static void SerializecarArray(Car[] carArr)
        {
            _serializer = new XmlSerializer(typeof(Car[]));
            filenames = Directory.GetFiles(Directory.GetCurrentDirectory()).Where(x => x.Contains("CarArr_")).ToArray();

            using (Stream fileStream = new FileStream(Directory.GetCurrentDirectory() + @"\CarArr_" + (filenames.Length + 1) + ".xml", FileMode.Create))
            {
                _serializer.Serialize(fileStream, carArr);
            }
        }
        static private bool isDirectoryOrFileExists(string fileName)
        {
            if (!Directory.Exists(SAVING_DIR_NAME)) { MessageBox.Show("The directory with the serialised data is missing, so no data can be restored. Null will be returned."); return false; }
            else
            { if (!File.Exists(fileName)) { MessageBox.Show("The file with the serialised data is missing, so no data can be restored. Null will be returned."); return false; } }

            return true;
        }
        public static Car DeSerializeACar(string fileName)
        {
            if (!isDirectoryOrFileExists(fileName)) return null;

            _serializer = new XmlSerializer(typeof(Car));
            Car deserializedCar;
            using (Stream fileStream = new FileStream(fileName, FileMode.Open))
            {
                deserializedCar = _serializer.Deserialize(fileStream) as Car;
            }
            return deserializedCar;
        }
        public static Car[] DeSerializeCarArray(string fileName)
        {
            if (!isDirectoryOrFileExists(fileName)) return null;

            _serializer = new XmlSerializer(typeof(Car[]));
            Car[] deserializedCarArr;
            using (Stream fileStream = new FileStream(fileName, FileMode.Open))
            {
                deserializedCarArr = _serializer.Deserialize(fileStream) as Car[];
            }
            return deserializedCarArr;
        }

        public override string ToString()
        {
            string str = string.Empty;
            foreach (var s in this.GetType().GetProperties()) str += $"{s.Name}: {s.GetValue(this)}\n";

            str += "------------\n";
            return str;
        }


    }
}
