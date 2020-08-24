using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace IEnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ls = Test1();
            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }


        public static IEnumerable<int> Test1()
        {
            Thread.Sleep(1000);
            Console.WriteLine("我进来了");
            yield return -2;
            Console.WriteLine("我又进来了");
            yield return -1;
            var arr = new[] { 0,1,2,3,4,5,6,7 };
            foreach (var item in arr)
            {
                Thread.Sleep(1000);
                if (item > 5) { yield break; }
                yield return item;
            }
        }


    }
}
