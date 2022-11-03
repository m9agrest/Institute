using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class MathPendulum
    {
        public double a, d;
        public int m;
        public MathPendulum(double a, double d, int m)
        {
            this.m = m;
            this.a = a;
            this.d = d;
        }
        public double X(int t) => a * Math.Cos(t * Math.Sqrt(9.81 / d));
        public double CalculateT() => 2 * Math.PI * Math.Sqrt(d / 9.81);
        public override string ToString() => $"a : {a}; b : {d}; m : {m};";
    }
}
