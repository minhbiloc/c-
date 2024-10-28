using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vong_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i+=2) // i+=2  là i = i+2
            {
                Console.WriteLine("i = " + i);
            }
            Console.ReadKey();
        }

    }
}
