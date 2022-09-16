using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MethodArray
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
                    if (Math.Abs(n) > nmax) this.imax = arrl.Count - 1;
                }
                catch (Exception e) { }
            }
        }
        this.array = arrl.ToArray();
    }

    int[] array;
    int imax;
    public int N
    {
        get
        {
            int n = 0;
            for (int i = 0; i < this.array.Length; i++)
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
            for (int i = 0; i < this.imax; i++)
            {
                s += Math.Abs(this.array[i]);
            }
            return s;
        }
    }
}
