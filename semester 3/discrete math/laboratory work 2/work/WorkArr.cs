using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2dis
{
	class WorkArr
	{
		public int[,] CreateArrayAdjacency(int size)
		{
			Console.WriteLine("Write <1> when the passage from one vertex to another is free(there is an edge).\nWrite < 0 > if false");
			int vertex = 123;
			int[,] arraymetod = new int[size, size];
			for (int i = 0; i < size; i++)
			{
				Console.WriteLine("{0} Row:", i + 1);
				for (int j = 0; j < size; j++)
				{
					bool vertexChecking = false;
					while (vertexChecking == false)
					{
						Console.Write("Enter {0} number: ", j + 1);
						vertex = int.Parse(Console.ReadLine());
						if (vertex == 0 || vertex == 1)
						{
							vertexChecking = true;
						}
						else
						{
							Console.WriteLine("Invalid input (Enter 1 or 0)");
						}
					}
					arraymetod[i, j] = vertex;
				}
			}
			EnterArrayAdjacency(arraymetod, size);
			return arraymetod;
		}
		public int[,] CreateArrayIncidence()
		{
			int vertex = 0; int edges = 0; int edgesTest = 123;
			Console.Write("Enter the number of vertices: ");
			vertex = int.Parse(Console.ReadLine());
			Console.Write("Enter the number of edges: ");
			edges = int.Parse(Console.ReadLine());
			int[,] arraymetod = new int[vertex, edges];
			Console.WriteLine("Write <1> if an edge enters a vertex.\nWrite <-1> if an edge exits a vertex.\nWrite < 0 > if the vertex and edge are not incident.");
			for (int i = 0; i < vertex; i++)
			{
				Console.WriteLine("{0} Vertex:", i + 1);
				for (int j = 0; j < edges; j++)
				{
					bool edgesChecking = false;
					while (edgesChecking == false)
					{
						Console.Write("Enter {0} edge: ", j + 1);
						edgesTest = int.Parse(Console.ReadLine());
						if (edgesTest == 0 || edgesTest == 1 || edgesTest == -1)
						{
							edgesChecking = true;
						}
						else
						{
							Console.WriteLine("Invalid input (Enter 1, 0 or -1)");
						}
					}
					arraymetod[i, j] = edgesTest;
				}
			}
			EnterArrayIncidence(arraymetod, vertex, edges);
			return arraymetod;
		}
		//найти смежные вершины с задаваемой вершиной
		public void FindVertex(int[,] arrayIncidents, int size)
		{
			Console.WriteLine("Search for adjacent vertices");
			Console.WriteLine("Choose the vertex:");
			Console.Write("Enter index of vertex (abc-z): ");
			string vertex = Console.ReadLine();
			int indexVertex = 0;
			for (int i = 0; i < size; i++)
			{
				if (((char)(97 + i)).ToString() == vertex)
				{
					indexVertex = i;
				}
			}
			Console.WriteLine("Entered vertes: {0}", vertex);
			for (int i = 0; i < size; i++)
			{
				if (arrayIncidents[i, indexVertex] == 1)
				{
					Console.WriteLine("Vertex <{0}> adjacent to the vertex <{1}>",
				   vertex, (char)(97 + i));
				}
			}
		}
		public void EnterArrayAdjacency(int[,] arraymetod, int size)
		{
			Console.WriteLine("\nArray Adjacency:");
			Console.Write(" ");
			for (int i = 0; i < size; i++)
			{
				Console.Write("{0} ", (char)(97+i));
			}
			Console.WriteLine();
			for (int i = 0; i < size; i++)
			{
				Console.Write("{0}|", (char)(97 + i));
				for (int j = 0; j < size; j++)
				{
					Console.Write("{1} ", i, arraymetod[i, j]);
				}
				Console.WriteLine();
			}
		}
		public void EnterArrayIncidence(int[,] arraymetod, int vertex, int edges)
		{
			Console.WriteLine("\nArray Incidence:");
			Console.Write(" ");
			for (int i = 0; i < edges; i++)
			{
				Console.Write("{0,2} ", (char)(97 + i));
			}
			Console.WriteLine();
			for (int i = 0; i < vertex; i++)
			{
				Console.Write("{0,2}|", i);
				for (int j = 0; j < edges; j++)
				{
					Console.Write("{1,2} ", i, arraymetod[i, j]);
				}
				Console.WriteLine();
			}
		}
	}
}
