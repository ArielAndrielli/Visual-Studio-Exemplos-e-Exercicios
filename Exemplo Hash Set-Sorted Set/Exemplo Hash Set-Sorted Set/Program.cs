using Exemplo_Hash_Set_Sorted_Set.Entities;
using System;
using System.Collections.Generic;

namespace Exemplo_Hash_Set_Sorted_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo HashSet
            /*
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Telefone");
            set.Add("Notebook");
            set.Add("Tablet");
            set.Add("Computador");

            Console.WriteLine(set.Contains("Notebook"));

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }
            */
            #endregion

            #region Exemplo SortedSet
            /*
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 7, 9, 10 };
            SortedSet<int> b = new SortedSet<int>() { 2, 1, 3, 7, 10, 12, 18 };

            //PrintCollection(a);
            //PrintCollection(b);

            //Union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            //Intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //Difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);

            static void PrintCollection<T>(IEnumerable<T> collection)
            {
                foreach (T obj in collection)
                {
                    Console.Write(obj + " ");
                }
                Console.WriteLine();
            }

            */
            #endregion

            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(a.Contains(prod));

            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p));
        }
    }
}
