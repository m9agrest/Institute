using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.aaa
{
    partial class MethodArray
    {
        public MethodArray(int n) : this(n, 0, int.MaxValue, new Random()) { }
        public MethodArray(int n, int max) : this(n, 0, max, new Random()) { }
        public MethodArray(int n, int min, int max) : this(n, min, max, new Random()) { }
        public MethodArray(int n, Random rand) : this(n, 0, int.MaxValue, rand) { }
        public MethodArray(int n, int max, Random rand) : this(n, 0, max, rand) { }
        public MethodArray(int n, int min, int max, Random rand)
        {
            if (n < 0) n = 0;
            if (min > max)
            {
                int h = max;
                max = min;
                min = h;
            }
            int nmax = 0;
            this.array = new int[n];
            for (int i = 0; i < n; i++)
            {
                this.array[i] = rand.Next(min, max);
                if (Math.Abs(this.array[i]) > nmax) this.imax = i;
            }
        }
    }
}
