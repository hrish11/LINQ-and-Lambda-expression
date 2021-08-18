using System;
using System.Linq;

namespace CountingNoOfCharInStringUsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "ererecvveredf";
            char[] chararray = (test).ToCharArray();
            var query1 = chararray.Distinct().OrderBy(s => s);

            foreach (char item in query1)
            {
                int freq = chararray.Count(f => (f == item));

                if (chararray.Contains(item))
                {
                    Console.WriteLine(item + ":" + freq);
                }
            }
            Console.ReadKey();
        }
    }
}
