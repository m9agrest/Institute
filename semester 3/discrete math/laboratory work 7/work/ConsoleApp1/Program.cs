using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the element you are looking for ");
            int search = Convert.ToInt32(Console.ReadLine());
            InitialArray IA = new InitialArray(n);
            SortArray SA = new SortArray(IA);
            Console.WriteLine($"Search element {search}:");
            int count;
            if (InitialArray.linearSearchUnsorted(IA.arr, search, out count) == true)
            {
                Console.WriteLine($"Element {search} found.\n" + 
                    $"Number of search iterations in the original array {count}");
            }
            else
            {
                Console.WriteLine($"Element {search} not found.");
            }
            if (SortArray.BinarySearch(SA.arr, search, out count) == true)
            {
                Console.WriteLine($"Number of search iterations in the sorted array {count}");
            }
            BST tree = new BST();
            for (int i = 0; i < IA.arr.Length; i++)
            {
                tree.Add(IA.arr[i], i);
            }
            List<int> indices;
            if (tree.Search(search, out indices, out count) == true)
            {
                Console.WriteLine($"Number of search iterations in a binary tree {count}");
            }
            Console.ReadLine();
        }
    }
}
