using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tong_va_hieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap tong 2 so: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("nhap hieu 2 so: ");
            double b = Convert.ToDouble(Console.ReadLine());

        
            double x = (a + b) / 2;
            double y = (a - b) / 2;

            Console.WriteLine("gia tri x la : " + x);
            Console.WriteLine("gia tri cua y la : " + y);
            Console.ReadKey();  

        }
    }
}
