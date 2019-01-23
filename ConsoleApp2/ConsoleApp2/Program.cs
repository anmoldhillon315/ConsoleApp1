using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 0;
            while (i < 5)
            {
                i++;
                sum += i;
            }

            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
