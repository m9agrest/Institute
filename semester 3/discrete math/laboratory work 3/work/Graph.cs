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
            for(int i = 0; i < numEdges; i++)
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
