using System;
using System.Linq;

namespace CountingNoOfCharInStringUsingLinq
{
    class Program
    {
        public static void GetCharCount(string text)
        {
            char[] chararray = (text).ToCharArray();

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

        static void Main(string[] args)
        {
            string test = "ererecvveredf";
            GetCharCount(test);

        }
    }
}
