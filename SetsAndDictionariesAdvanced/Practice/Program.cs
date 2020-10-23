using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            //HashSet<int> a = new HashSet<int>() { 1, 2, 3, 4, 5, 6 };
            //HashSet<int> b = new HashSet<int>() { 5, 6, 7, 8, 9, 10 };

            //b.ExceptWith(a);
            //Console.WriteLine(string.Join("  ",a));//1  2  3  4  5  6

            //Console.WriteLine(string.Join("  ", b));//  7  8  9  10

            HashSet<int> a = new HashSet<int>() { 1, 2, 3, 4, 5, 6 };
            HashSet<int> b = new HashSet<int>() { 5, 6, 7, 8, 9, 10 };
            a.IntersectWith(b);
            Console.WriteLine(string.Join("  ", a));//5  6
            Console.WriteLine(string.Join("  ", b));// 5  6  7  8  9  10
            Console.WriteLine(a.IsSubsetOf(b));//true
            Console.WriteLine(b.IsSupersetOf(a));//true

            a.UnionWith(b);// collect all unique elements from two sets in one hashset
        }
    }
}
