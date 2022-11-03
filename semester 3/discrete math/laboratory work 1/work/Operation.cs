using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Operation
    {
        static public bool IsSet(string[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i].Equals(array[j]))
                        return false;
            return true;
        }
        static public string[] Remove(string[] array)
        {
            string[] a = new string[array.Length]; 
            int k = 0;
            /* изменён
            for (int i = array.Length - 1; i >= 0; i--)
            {
                bool b = true;
                for (int j = i - 1; j >= 0; j--)
                    if (array[i].Equals(array[j]))
                    {
                        b = false;
                        break;
                    }
                if (b)
                {
                    a[k] = array[i];
                    k++;
                }
            }
            */
            for(int i = 0; i < array.Length; i++)
            {
                bool b = true;
                for (int j = 0; j < k; j++)
                    if(array[i].Equals(a[j]))
                    {
                        b = false;
                        break;
                    }
                if (b)
                {
                    a[k] = array[i];
                    k++;
                }
            }

            return arrays(a, k);
        }
       static public string[] Union(string[] A, string[] B)
        {
            /* Лишние операции и циклы
            if (!isSet(A))
                A = Remove(A);
            if (!isSet(B))
                B = Remove(B);
            */
            string[] C = new string[A.Length + B.Length];
            //можно попробовать асинхронно заполнять массив C
            for (int i = 0; i < A.Length; i++)
                C[i] = A[i];
            for (int i = 0; i < B.Length; i++)
                C[i + A.Length] = B[i];
            return Remove(C);
        }
        static public string[] Intersection(string[] A, string[] B)
        {
            /* Лишние операции и циклы
            if (!isSet(A))
                A = Remove(A);
            if (!isSet(B))
                B = Remove(B);
            */
            string[] C = new string[A.Length < B.Length ? A.Length : B.Length];
            int k = 0;
            for(int i = 0; i < A.Length; i++)
            {
                bool b = false;
                for(int j = 0; j < B.Length; j++)
                    if (A[i].Equals(B[j]))
                    {
                        b = true;
                        break;
                    }
                if (b)
                {
                    C[k] = A[i];
                    k++;
                }
            }

            return Remove(arrays(C,k));
        }

        static public string[] Difference(string[] A, string[] B)
        {
            /* Лишние операции и циклы
            if (!isSet(A))
                A = Remove(A);
            if (!isSet(B))
                B = Remove(B);
            */
            string[] C = new string[A.Length];
            int k = 0;
            for(int  i = 0; i < A.Length; i++)
            {
                bool b = true;
                for(int j = 0; j < B.Length; j++)
                    if (A[i].Equals(B[j]))
                    {
                        b = false;
                        break;
                    }
                if (b)
                {
                    C[k] = A[i];
                    k++;
                }
            }

            return Remove(arrays(C, k));
        }


        static private string[] arrays(string[] a, int k)
        {
            string[] r = new string[k];
            for (int i = 0; i < k; i++)
                r[i] = a[i];
            return r;
        }
    }
}
