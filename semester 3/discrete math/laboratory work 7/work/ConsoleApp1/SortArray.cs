using System;

namespace ConsoleApp1
{
    internal class SortArray
    {
        public int[] arr;
        public SortArray(InitialArray a)
        {
            arr = a.arr;
            Array.Sort(arr);
        }
        public static bool BinarySearch(int[] arr, int value, out int interCount)
        {
            interCount = 0;
            int low = 0;
            int high = arr.Length - 1;
            int mid;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                interCount++;
                if (arr[mid] == value)
                {
                    return true;
                }
                else if (arr[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return false;
        }
    }
}
