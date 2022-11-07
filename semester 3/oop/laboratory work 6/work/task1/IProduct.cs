using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.task1
{
    interface IProduct
    {
        public double Price { get; set; }
        public double Discount { get; set; }
        public string Manufacturer { get; set; }
        public DateTime RreleaseDate { get; set; }
        public double DiscountedPrice();
    }
}
