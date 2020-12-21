using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nested_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                int j = 0;
                do
                {
                    Console.Write("({0},{1}) ", i, j);
                    j++;
                } while (j < 2);
                i++;
                Console.WriteLine();

            } while (i < 2);
        }
    }
}
