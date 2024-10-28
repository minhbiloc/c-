using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_true
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                n++; // tăng biến n lên 1
                Console.WriteLine("n= " + n);
               
            }
            Console.ReadKey();
        }

    }
}
