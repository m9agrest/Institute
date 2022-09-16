using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.aaa
{
    partial class MethodArray
    {
        public MethodArray(string array)
        {
            string[] arrs = array.Split(" ");
            List<int> arrl = new List<int>();
            int nmax = 0;
            for (int i = 0; i < arrs.Length; i++)
            {
                if (arrs[i] != null && arrs[i] != "")
                {
                    try
                    {
                        int n = Convert.ToInt32(arrs[i]);
                        arrl.Add(n);
                        if (Math.Abs(n) > nmax) this.imax = arrl.Count-1;
                    }
                    catch (Exception e) { }
                }
            }
            this.array = arrl.ToArray();
        }
    }
}
