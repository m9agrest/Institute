using System;

namespace ConsoleApp1
{
    internal class InitialArray
    {
        public int[] arr;
        public InitialArray(int value)
        {
            arr = new int[value];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
        }
        public static bool linearSearchUnsorted(int[] arr, int search, out int interCount)
        {
            interCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                interCount++;
                if (search == arr[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
