using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Graph
    {
        public int[,] adjacency;
        public int numEdges; // количество вершин графа
        private const int inf = 1000;

        public Graph(string fileName)
        {
            int n, j;
            string line;
            char[] delimiterChars = new char[] { ',', ' ', ';', '.' };
            using (StreamReader file = new StreamReader(fileName))
            {
                n = int.Parse(file.ReadLine()); // ввод размерности
                this.numEdges = n;
                this.adjacency = new int[n, n];
                for (int i = 0; (i < n) && ((line = file.ReadLine()) != null); i++) // ввод матрицы
                {
                    string[] numbers = line.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    j = 0;
                    foreach (string numString in numbers)
                    {
                        int x;
                        bool canConvert = int.TryParse(numString, out x);
                        if (canConvert == true)
                        {
                            this.adjacency[i, j] = x;
                            j++;
                        }
                    }
                }
            }
        }
        public static int[] BFS(Graph g, int num, RichTextBox box) //поиск в ширину
        {
            box.Text = "";
            int[] mark = new int[g.numEdges];
            int[] parent = new int[g.numEdges];
            for (int i = 0; i < g.numEdges; i++)
            {
                mark[i] = 0;
                parent[i] = num;
            }
            box.Text += "Вершины в порядке обхода\n";
            Queue<int> Q = new Queue<int>();
            int v = num;
            mark[v] = 1;
            Q.Enqueue(v);
            box.Text += $"{v}\n";
            while (Q.Count != 0)
            {
                v = Q.Dequeue();
                for (int i = 0; i < g.numEdges; i++)
                {
                    if ((g.adjacency[v, i] != 0) && (mark[i] == 0))
                    { // все непомеченные вершины,
                        mark[i] = 1;
                        Q.Enqueue(i);
                        parent[i] = v;
                        box.Text += $"{i}\n";
                    }
                }
                mark[v] = 2;
            }
            return parent;
        }

        public static void Path(int[] arrayEntered, int num, RichTextBox box) //путь
        {
            box.Text += $"Пути от {num}:\n";
            for (int j = 0; j < arrayEntered.Length; j++)
            {
                int i = j;
                string str = "";
                if (i != num)
                {
                    str += Convert.ToString(i);
                    while (i != num)
                    {
                        str += Convert.ToString(arrayEntered[i]);

                        i = arrayEntered[i];
                    }
                    string obrat = "";
                    for (int k = str.Length - 1; k >= 0; k--)
                    {
                        obrat += $"{str[k]} - ";
                    }
                    box.Text += $"{obrat}Длина пути {str.Length - 1}\n";
                }
            }
        }

        public static void DijkstraAlgm(Graph g, int vBegin, RichTextBox box)
        {
            int[] Distance = new int[g.numEdges];
            int[] parent = new int[g.numEdges];
            int[] distance = new int[g.numEdges];
            int[,] matr = new int[g.numEdges, g.numEdges];
            // инициализация
            for (int i = 0; i < g.adjacency.GetLength(0); i++)
                for (int j = 0; j < g.numEdges; j++)
                {
                    matr[i, j] = g.adjacency[i, j];
                    if (g.adjacency[i, j] == 0)
                        matr[i, j] = int.MaxValue;
                }
            HashSet<int> edges = new HashSet<int>();
            for (int i = 0; i < g.numEdges; i++)
            {
                edges.Add(i);
                distance[i] = matr[vBegin, i];
                if (distance[i] < int.MaxValue)
                    parent[i] = vBegin;
            }
            distance[vBegin] = 0;
            parent[vBegin] = -1;
            edges.Remove(vBegin);
            while (edges.Count != 0)
            {
                int minDistance = int.MaxValue;
                int minEdge = -1;
                foreach (int u in edges)
                {
                    if (distance[u] < minDistance)
                    {
                        minDistance = distance[u];
                        minEdge = u;
                    }
                }
                if (minEdge != -1)
                    edges.Remove(minEdge);
                foreach (int u in edges)
                {
                    if (matr[minEdge, u] < int.MaxValue)
                    {
                        distance[u] = Math.Min(
                       Distance[u],
                       Distance[minEdge] + matr[minEdge, u]
                       );
                        if (distance[u] ==
                       (distance[minEdge] + matr[minEdge, u])
                       )
                        {
                            parent[u] = minEdge;
                        }
                    }
                }
            }
            box.Text += $"Tracer from to ";
            for (int i = parent.Length - 1; i > 0; i--)
            {
                box.Text += $"{parent[i]} ";
            }
        }

        public void GraphFloyd(Graph g, RichTextBox box)
        {
            int[] distance = new int[g.numEdges];
            int[,] matrdist = new int[g.numEdges, g.numEdges];
            int[] parent = new int[g.numEdges];
            int[,] matr = new int[g.numEdges, g.numEdges];
            // инициализация
            for (int i = 0; i < g.adjacency.GetLength(0); i++)
                for (int j = 0; j < g.numEdges; j++)
                {
                    matr[i, j] = g.adjacency[i, j];
                    if (g.adjacency[i, j] == 0)
                        matr[i, j] = int.MaxValue;
                }
            box.Text += Environment.NewLine;
            for (int vBegin = 0; vBegin < g.numEdges; vBegin++)
            {
                HashSet<int> edges = new HashSet<int>();
                for (int i = 0; i < g.numEdges; i++)
                {
                    edges.Add(i);
                    distance[i] = matr[vBegin, i];
                    if (distance[i] < int.MaxValue)
                        parent[i] = vBegin;
                }
                distance[vBegin] = 0;
                parent[vBegin] = -1;
                edges.Remove(vBegin);
                while (edges.Count != 0)
                {
                    int minDistance = int.MaxValue;
                    int minEdge = -1;
                    foreach (int u in edges)
                    {
                        if (distance[u] < minDistance)
                        {
                            minDistance = distance[u];
                            minEdge = u;
                        }
                    }
                    if (minEdge != -1)
                        edges.Remove(minEdge);
                    foreach (int u in edges)
                    {
                        if (matr[minEdge, u] < int.MaxValue)
                        {
                            distance[u] = Math.Min(distance[u], distance[minEdge] +
                           matr[minEdge, u]);
                            if (distance[u] == (distance[minEdge] + matr[minEdge,
                           u]))
                            {
                                parent[u] = minEdge;
                            }
                        }
                    }
                }
                box.Text += ($"Расстояния от вершины {vBegin + 1} до: ");
                for (int i = 0; i < g.numEdges; i++)
                {
                    matrdist[i, vBegin] = distance[i];
                    box.Text += Environment.NewLine;
                    box.Text += ($"{i+1} = {distance[i]}");
                }
                box.Text += Environment.NewLine;
            }
        }

        public void Print(int[,] distance, int verticesCount, RichTextBox box)
        {
            Console.WriteLine("Кратчайшее расстояния между каждой парой вершин:");

            for (int i = 0; i < verticesCount; ++i)
            {
                for (int j = 0; j < verticesCount; ++j)
                {
                    if (distance[i, j] == inf)
                        box.Text += $"{inf,5}";
                    else
                        box.Text += $"{distance[i, j].ToString(),5}";
                }

                box.Text += $"\n";
            }
        }
    }
}
