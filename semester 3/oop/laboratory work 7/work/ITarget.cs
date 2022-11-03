using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    interface ITarget
    {
        public void ModifMass(int dm);
        public double CalculateW();
        public string GetData();
    }
}
