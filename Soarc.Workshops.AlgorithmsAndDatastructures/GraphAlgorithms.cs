using System;
using System.Collections.Generic;
using System.Text;

namespace Soarc.Workshops.AlgorithmsAndDatastructures
{
    public class GraphAlgorithms
    {
        public static void Run()
        {
            var graph = new bool[8, 8];
            graph[1, 2] = true;
            graph[1, 3] = true;
            graph[1, 4] = true;
            graph[5, 6] = true;
            graph[2, 5] = true;
            graph[2, 6] = true;
            graph[3, 7] = true;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (graph[i, j] == true)
                        graph[j, i] = true;
                }
            }

            DoDFS(graph);
            DoBFS(graph);
        }

        public static void DoDFS(bool[,] graph)
        {
            var stack = new Stack<int>();
            var visited = new HashSet<int>();
            stack.Push(1);
            visited.Add(1);
            while (stack.Count != 0)
            {
                var v = stack.Pop();
                
                for (int i = 1; i < 8; i++)
                {
                    if (graph[v, i] == true && !visited.Contains(i))
                    {
                        stack.Push(i);
                        visited.Add(i);
                    }
                }
                Console.Write($"{v} -> ");
            }

            Console.WriteLine("End.");
        }

        public static void DoBFS(bool[,] graph)
        {
            var queue = new Queue<int>();
            var visited = new HashSet<int>();
            queue.Enqueue(1);
            visited.Add(1);
            while (queue.Count != 0)
            {
                var v = queue.Dequeue();
                
                for (int i = 1; i < 8; i++)
                {
                    if (graph[v, i] == true && !visited.Contains(i))
                    {
                        queue.Enqueue(i);
                        visited.Add(i);
                    }

                }
                Console.Write($"{v} -> ");

            }
            Console.WriteLine("End.");
        }
    }
}
