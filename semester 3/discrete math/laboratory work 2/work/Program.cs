using lab2dis;
using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkArr arr = new WorkArr();
            Console.WriteLine("Creating an adjacency matrix:");
            Console.Write("Enter the number of vertices: N => ");
            int size = int.Parse(Console.ReadLine());
            int[,] arrayAdjacency = arr.CreateArrayAdjacency(size);
            arr.FindVertex(arrayAdjacency, size);
            Console.WriteLine("\n\nCreating a graph incidence matrix: ");
            int[,] arrayIncidence = arr.CreateArrayIncidence();
            Console.ReadLine();
        }
    }
}
