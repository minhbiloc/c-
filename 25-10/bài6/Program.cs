using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            const int DoSoi = 100;
            const int DoDong = 0;
            const  double PI = 3.14;
            Console.WriteLine($" Do dong cua nuoc la {DoDong}");
            Console.WriteLine($" Do dong cua nuoc la {DoSoi}");
            Console.WriteLine($" Pi =  {PI}");
            Console.ReadKey(); 
        }
    }
}
