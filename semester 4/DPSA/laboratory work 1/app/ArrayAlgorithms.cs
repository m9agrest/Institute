using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class ArrayAlgorithms
    {
        static private Random rnd = new Random(111);
        static private void Swap(ref int A, ref int B)
        {
            int C = A;
            A = B;
            B = C;
        }
        static public int[] Copy(int[] array)
        {
            int[] arrayCopy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                arrayCopy[i] = array[i];
            return arrayCopy;
        }

        static public int[] Generation(int Length, int min, int max)
        {
            int[] array = new int[Length];
            for (int i = 0; i < Length; i++)
                array[i] = rnd.Next(min, max);
            return array;
        }


        static public void GnomeSort(int[] array)
        {
            int i = 1;
            int j = 2;
            while (i < array.Length)
            {
                if (i > 0 && array[i] > array[i - 1])
                {
                    i = j;
                    j++;
                } 
                else
                {
                    Swap(ref array[i], ref array[i - 1]);
                    i--;
                    if(i == 0)
                    {
                        i = j;
                        j++;
                    }
                }
            }
        }
        static public void GnomeSort(int[] array, ref long comparisons, ref long permutations)
        {
            int i = 1;
            int j = 2;
            while (i < array.Length)
            {
                comparisons++;
                if (i > 0 && array[i] > array[i - 1])
                {
                    i = j;
                    j++;
                }
                else
                {
                    permutations++;
                    Swap(ref array[i], ref array[i - 1]);
                    i--;
                    if (i == 0)
                    {
                        i = j;
                        j++;
                    }
                }
            }
        }
        static public void BubleSort(int[] array, ref long comparisons, ref long permutations)
        {
            for (int k = 0; k < array.Length; k++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    comparisons++;
                    if (array[i] > array[i + 1])
                    {
                        permutations++;
                        Swap(ref array[i + 1], ref array[i]);
                    }
                }
            }
        }
        static public void BubleSort(int[] array)
        {
            for (int k = 0; k < array.Length; k++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i + 1], ref array[i]);
                    }
                }
            }
        }
        static public void CountingSort(int[] array, ref long comparisons, ref long permutations)
        {
            int maxV = array.Max();
            int minV = array.Min();
            int[] B = new int[maxV - minV + 1];
            for (int i = 0; i < array.Length; i++)
            {
                B[array[i] - minV]++;
            }
            int q = 0;
            for (int i = 0; i < (maxV - minV + 1); ++i)
            {
                for (int j = 0; j < B[i]; ++j)
                {
                    permutations++;
                    array[q++] = minV + i;
                }
            }
        }
        static public void CountingSort(int[] array)
        {
            int maxV = array.Max();
            int minV = array.Min();
            int[] B = new int[maxV - minV + 1];
            for (int i = 0; i < array.Length; i++)
            {
                B[array[i] - minV]++;
            }
            int q = 0;
            for (int i = 0; i < (maxV - minV + 1); ++i)
            {
                for (int j = 0; j < B[i]; ++j)
                {
                    array[q++] = minV + i;
                }
            }
        }
    }
}
