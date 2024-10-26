using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kq , kq1;
            int a = 6, b = 10;
            kq = (a != b) || (a < 3);
            kq1 = (a != b) && (a < 3);
            Console.WriteLine($" gia tri cua kq la " + kq);
            Console.WriteLine($" gia tri cua kq la " + kq1);
            Console.ReadLine();
        }
    }
}
