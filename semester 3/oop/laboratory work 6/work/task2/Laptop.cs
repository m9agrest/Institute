using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.task2
{
    class Laptop : IComparable
    {
        public string Model;
        public string Processor;
        public int ScreenHeight;
        public int ScreenWidth;
        public double Width;
        public double Price;
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Laptop Obj = (Laptop)obj;
            if(Obj.Price > Price) return 1;
            if(Obj.Price == Price) return 0;
            return -1;
        }
    }
}
