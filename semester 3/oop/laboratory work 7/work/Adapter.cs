using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Adapter : ITarget
    {
        private MathPendulum mathP;
        public Adapter(MathPendulum mathP) => this.mathP = mathP;
        public double CalculateW() => 2 * Math.PI / mathP.CalculateT();
        public void ModifMass(int dm) => mathP.m = dm;
        public string GetData() => mathP.ToString();
    }
}
