using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_AND_LAMBDA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);
            List<int> test = list.FindAll(x => x > 1);


            var query = from i in list
                        where i>3
                        select i;
            var query1 = list.Where(l => l > 4)
                            .OrderByDescending(l =>l)
                            .Select(l => l);
       

            foreach (var item in query1)
            {
                Console.WriteLine(item);
            }
            //foreach (var num in test)
            //{
            //    Console.Write("{0} ", num);
            //}

            //foreach (var num in evenNumbers)
            //{
            //    Console.WriteLine("{0} ", num);
            //}
            Console.WriteLine();
            Console.Read();
        }
    }
}
