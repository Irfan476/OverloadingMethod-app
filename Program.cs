using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();

            Console.WriteLine("Minimum #1: {0}", number.FindMinimum(10, 2));
            Console.WriteLine("Minimum #2: {0}", number.FindMinimum(20, 54, 15));
            Console.WriteLine();
            Console.WriteLine("Maximum #1: {0}", number.FindMaximum(98, 100));
            Console.WriteLine("Maximum #2: {0}", number.FindMaximum(13, 64, 52));

            Console.WriteLine("Tekan ENTER untuk melanjutkan");
            Console.ReadKey();
        }
    }
}
