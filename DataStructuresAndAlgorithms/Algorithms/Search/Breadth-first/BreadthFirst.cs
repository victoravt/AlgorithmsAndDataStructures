using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Algorithms.Search.Breadth_first
{
    internal static class BreadthFirst
    {
        // graph of my friends (actually 2 dimentional array)
        static Dictionary<string, List<string>> graph = new();

        static BreadthFirst()
        {
            graph.Add("A", new List<string>() { "B", "D" });
            graph.Add("B", new List<string>() { "E", "F" });
            graph.Add("C", new List<string>() { "G", });
            graph.Add("D", new List<string>() { "C", "F" });
            graph.Add("E", new List<string>() { });
            graph.Add("F", new List<string>() { });
            graph.Add("G", new List<string>() { });
        }

        static T Traverse<T>(Dictionary<T, List<T>> graph, Func<T, bool> criteria)
        {
            HashSet<T> visited = new HashSet<T>();

            if(graph == null || graph.Count < 0) { return default(T); }

            Queue<T> queue = new Queue<T>();
            foreach(T t in graph.First().Value) //populate
            {
                queue.Enqueue(t);
            }

            while(queue.Count > 0)
            {
                T next = queue.Dequeue();
                if(visited.Contains(next))
                    continue; 

                visited.Add(next);
                Console.WriteLine($"Checking: {next}");

                if (criteria(next)) 
                {
                    Console.WriteLine($"Found: {next}");
                    return next;
                }

                // enqueue neighbours
                if (graph[next] != null)
                {
                    foreach (var n in graph[next])
                    {
                        queue.Enqueue(n);
                    }
                }
            }
            
            return default(T)!;
        }

        internal static void Run()
        {
            Traverse(graph, x => x == "G");
        }
    }
}


//foreach (var adj in graph)
//{
//    // create the queue
//    Queue<T> queue = new Queue<T>();
//    foreach (var node in adj.Value)
//    {
//        queue.Enqueue(node);
//    }

//    foreach (var item in queue)
//    {
//        // next person in queue
//        var next = queue.Dequeue();

//        // already checked
//        if (visited.Contains(next))
//            continue;

//        if (criteria(next))
//        {
//            return next;
//        }
//        else
//        {
//        }

//        visited.Add(adj.Key);
//    }
//}