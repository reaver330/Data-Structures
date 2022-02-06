using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DataStructures
{
    class Program
    {
        private const int TEN_MILLION = 10000000;

        static void Main(string[] args)
        {
            HashTable();
            B_tree();
            CircularLinkedList();
            LinkedList();
        }

        private static void HashTable()
        {
            Console.WriteLine("Hello Hash-table World!");

            Stopwatch sw = new Stopwatch();
            sw.Start();

            HashTable ht = new HashTable(TEN_MILLION);
            for (long l = 0; l <= TEN_MILLION; l++)
            {
                ht.Insert(l);
            }

            TimeSpan ts = sw.Elapsed;
            string elapsedTime = $"{ts.Hours}:{ts.Minutes}:{ts.Seconds}:{ts.Milliseconds}ms";
            sw.Stop();
            Console.WriteLine("Hash-table Insert elapsed time: " + elapsedTime);

            sw = Stopwatch.StartNew();

            long? s = ht.Search(TEN_MILLION);

            TimeSpan ts1 = sw.Elapsed;
            elapsedTime = $"{ts1.Hours}:{ts1.Minutes}:{ts1.Seconds}:{ts1.Milliseconds}ms. ({ts1.Ticks}ticks)";
            sw.Stop();

            Console.WriteLine("Hash-table search elapsed time: " + elapsedTime);
        }

        private static void CircularLinkedList()
        {
            Console.WriteLine("Hello Circular-Doubly-Linked-List World!");

            CircularLinkedList ll = new CircularLinkedList();

            Stopwatch sw = new Stopwatch();

            sw.Start();

            for (long l = 0; l <= TEN_MILLION; l++)
            {
                ll.Insert(l);
            }

            TimeSpan ts = sw.Elapsed;
            string elapsedTime = $"{ts.Hours}:{ts.Minutes}:{ts.Seconds}:{ts.Milliseconds}ms";
            sw.Stop();

            Console.WriteLine("Circular Doubly-Linked-List Insert elapsed time: " + elapsedTime);

            sw = Stopwatch.StartNew();

            LinkedListNode s = ll.Search(1);

            TimeSpan ts1 = sw.Elapsed;
            elapsedTime = $"{ts1.Hours}:{ts1.Minutes}:{ts1.Seconds}:{ts1.Milliseconds}ms. ({ts1.Ticks}ticks)";
            sw.Stop();

            Console.WriteLine("Circular Doubly-Linked-List search elapsed time: " + elapsedTime);
            
        }

        private static void LinkedList()
        {
            Console.WriteLine("Hello Doubly-Linked-List World!");

            LinkedList ll = new LinkedList();

            Stopwatch sw = new Stopwatch();

            sw.Start();

            for (long l = 0; l <= TEN_MILLION; l++)
            {
                ll.Insert(l);
            }

            TimeSpan ts = sw.Elapsed;
            string elapsedTime = $"{ts.Hours}:{ts.Minutes}:{ts.Seconds}:{ts.Milliseconds}ms";
            sw.Stop();

            Console.WriteLine("Doubly-Linked-List Insert elapsed time: " + elapsedTime);

            sw = Stopwatch.StartNew();

            LinkedListNode s = ll.Search(1);

            TimeSpan ts1 = sw.Elapsed;
            elapsedTime = $"{ts1.Hours}:{ts1.Minutes}:{ts1.Seconds}:{ts1.Milliseconds}ms. ({ts1.Ticks}ticks)";
            sw.Stop();

            Console.WriteLine("Doubly-Linked-List search elapsed time: " + elapsedTime);

        }

        private static void B_tree()
        {
            Console.WriteLine("Hello B-tree World!");
            B_tree bt = new B_tree(100);
            Stopwatch sw = new Stopwatch();

            sw.Start();

            for (long l = 0; l <= TEN_MILLION; l++)
            {
                bt.Insert(l);
            }


            TimeSpan ts = sw.Elapsed;
            string elapsedTime = $"{ts.Hours}:{ts.Minutes}:{ts.Seconds}:{ts.Milliseconds}ms";
            sw.Stop();

            Console.WriteLine("B-Tree Insert elapsed time: " + elapsedTime);

            //bt.traverse();

            sw = Stopwatch.StartNew();

            KeyValuePair<B_TreeNode, long>? pair = bt.Search(1);
            TimeSpan ts1 = sw.Elapsed;
            elapsedTime = $"{ts1.Hours}:{ts1.Minutes}:{ts1.Seconds}:{ts1.Milliseconds}ms. ({ts1.Ticks}ticks)";
            sw.Stop();

            Console.WriteLine("B-Tree search elapsed time: " + elapsedTime);
        }
    }
}
