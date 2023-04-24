using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Demo2
{
    public class Graph
    {
        public int n;
        public int[,] G;

        public Graph(int num)
        {
            this.n = num;
            G = new int[n + 1, n + 1];

            for (int i = 1; i <= num; i++)
                for (int j = 1; j <= num; j++)
                    G[i, j] = 0;
        }

        public void addEdge(int node1, int node2, int W)
        {
            G[node1, node2] = W;
            G[node2, node1] = W;
        }

        public void removeEdge(int node1, int node2)
        {
            G[node1, node2] = 0;
            G[node2, node1] = 0;
        }

        public bool isAdjacent(int node1, int node2)
        {
            return G[node1, node2] != 0;
        }

        public List<int> neighbors(int node)
        {
            List<int> neighbors = new List<int>();
            for (int i = 1; i <= this.n; i++)
            {
                if (isAdjacent(node, i))
                    neighbors.Add(i);
            }

            return neighbors;
        }

        public List<int> dfs(int start_node)
        {
            List<int> dfs_result = new List<int>();

            bool[] visited = new bool[this.n + 1];
            Stack<int> stack = new Stack<int>();

            for (int i = 1; i <= this.n; i++)
                visited[i] = false;

            visited[start_node] = true;
            stack.Push(start_node);

            while (stack.Count > 0)
            {
                int current_node = stack.Pop();
                dfs_result.Add(current_node);

                List<int> neighbors = this.neighbors(current_node);

                foreach(int neighbor in neighbors)
                {
                    if (!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        stack.Push(neighbor);
                    }
                }

            }

            return dfs_result;
           
        }

        private int min_key(int[] key, bool[] mst_set)
        {
            int min = int.MaxValue;
            int min_node = 0;

            for(int i = 1; i <= n; i++)
                if (mst_set[i] == false && key[i] < min)
                {
                    min = key[i];
                    min_node = i;
                }

            return min_node;
        }

        public int[] prim()
        {
            int[] parent = new int[n + 1];
            int[] key = new int[n + 1];
            bool[] mst_set = new bool[n + 1];

            for (int i = 1; i <= n; i++)
            {
                key[i] = int.MaxValue;
                mst_set[i] = false;
            }

            key[1] = 0;
            parent[1] = 0;

            for(int count = 0; count < n; count++)
            {
                int u = min_key(key, mst_set);
                mst_set[u] = true;

                for(int i = 1; i <= n; i++)
                    if (G[u, i] != 0 && mst_set[i] == false && G[u,i] < key[i])
                    {
                        parent[i] = u;
                        key[i] = G[u, i];
                    } 
                    
            }

            return parent;
                 
        }

        public int Number_Of_Connected_Components()
        {
            bool[] visted = new bool[this.n + 1];
            int num = 0;

            for (int i = 1; i <= this.n; i++)
                visted[i] = false;

            for (int i = 1; i <= this.n; i++)
            {
                if (!visted[i])
                {
                    num++;
                    List<int> dfs_resut = this.dfs(i);

                    foreach (int node in dfs_resut)
                        visted[node] = true;
                }
            }

            return num;
        }
    }
}
