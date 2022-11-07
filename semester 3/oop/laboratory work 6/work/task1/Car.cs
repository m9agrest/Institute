using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.task1
{
    class Car : IProduct, IClean
    {
        //переменные по заданию
        public string Brand;
        public string Color;
        public string BodyType;
        public double FuelConsumption;


        //реализация интерфейса IProduct
        private double price;
        public double Price { 
            get => price;
            set => price = value > 0 ? value : 0;
        }
        private double discount;
        public double Discount 
        { 
            get => discount;
            set => discount = value < 0 ? 0 : value > 100 ? 100 : value;
        }
        public string Manufacturer { get; set; }
        public DateTime RreleaseDate { get; set; }
        public double DiscountedPrice() => Price * (100 - Discount) / 100;


        //реализация интерфейся IClean
        private double degreeContamination;
        public double DegreeContamination 
        { 
            get => degreeContamination;
            set => degreeContamination = value > 0 ? value : 0;
        }
        public DateTime CleaningTime() => new DateTime((long)(DegreeContamination * 1000));
        public void CleanUp() => DegreeContamination = 0;
    }
}
