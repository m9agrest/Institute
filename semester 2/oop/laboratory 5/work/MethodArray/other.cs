using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.aaa
{
    partial class MethodArray
    {
        int[] array;
        int imax;
        public int N
        {
            get
            {
                int n = 0;
                for(int i = 0; i < this.array.Length; i++)
                {
                    if (this.array[i] == 50) n++;
                }
                return n;
            }
        }
        public int Summ
        {
            get
            {
                int s = 0;
                for(int i = 0; i < this.imax; i++) {
                    s += Math.Abs(this.array[i]);
                }
                return s;
            }
        }
    }
}
