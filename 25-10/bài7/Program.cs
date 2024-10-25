using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x,y ;
            Console.WriteLine("Nhap gia tri x la ");
             x = float.Parse(Console.ReadLine());

            Console.WriteLine("nhap gia tri xy la ");
            y = float.Parse(Console.ReadLine());

            float a1 = x + y;
            float a2 = x - y;
            float a3 = x * y;
            float a4 = x / y;
            float a5 = x / y;
            Console.WriteLine($"{x} + {y} = {a1}");
            Console.WriteLine($"{x} - {y} = {a2}");
            Console.WriteLine($"{x} * {y} = {a3}");
            Console.WriteLine($"{x} / {y} = {a4}");
            Console.WriteLine($"{x} % {y} = {a5}");
            Console.ReadKey();


        }
    }
}
