using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3dis
{
    class Graph
    {
        private int[,] adjacency;
        public int numEdges;
        public Graph(string file)
        {
            StreamReader r = new StreamReader(file);
            string strjson = r.ReadToEnd();
            JObject json = JObject.Parse(strjson);
            numEdges = (int)json["Edges"];
            adjacency = new int[numEdges, numEdges];
            for (int i = 0; i < numEdges; i++)
                for (int j = 0; j < numEdges; j++)
                    adjacency[i, j] = (int)json["Adjacency"][i][j];
        }
        public Graph() => numEdges = 0;


        public string BFS(int from, int to)
        {
            if (numEdges <= 0)
                return "нет пути";
            int[] mark = new int[numEdges];
            int[] parent = new int[numEdges];
            for (int i = 0; i < numEdges; i++)
            {
                mark[i] = 0;
                parent[i] = from;
            }
            Queue<int> Q = new Queue<int>();
            int v = from;
            mark[v] = 1;
            Q.Enqueue(v);
            while (Q.Count != 0)
            {
                v = Q.Dequeue();
                for (int i = 0; i < numEdges; i++)
                    if ((adjacency[v, i] != 0) && (mark[i] == 0))
                    {
                        mark[i] = 1;
                        Q.Enqueue(i);
                        parent[i] = v;
                    }
                mark[v] = 2;
            }
            return tracer(parent, from, to);
        }


        public string DijkstraAlgm(int vBegin, int vEnd)
        {
            int[] distance = new int[numEdges];
            int[] parent = new int[numEdges];
            int[,] matr = new int[numEdges, numEdges];
            // инициализация
            for (int i = 0; i < adjacency.GetLength(0); i++)
                for (int j = 0; j < numEdges; j++)
                {
                    matr[i, j] = adjacency[i, j];
                    if (adjacency[i, j] == 0)
                        matr[i, j] = int.MaxValue;
                }
            HashSet<int> edges = new HashSet<int>();
            for (int i = 0; i < numEdges; i++)
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
                            distance[u],
                            distance[minEdge] + matr[minEdge, u]
                       );
                        if (distance[u] == (distance[minEdge] + matr[minEdge, u]))
                        {
                            parent[u] = minEdge;
                        }
                    }
                }
            }

            return tracer(parent, vBegin, vEnd);
        }


        private string tracer(int[] parent, int from, int to)
        {
            string ret = to.ToString();
            int check = to;
            while (true)
            {
                check = parent[check];
                ret = check + "-" + ret;
                if (check == from)
                    break;
            }
            return ret;
        }







    }
}
