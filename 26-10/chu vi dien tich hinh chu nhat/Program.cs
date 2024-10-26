using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chu_vi_dien_tich_hinh_chu_nhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b ,s ,c ;
            Console.WriteLine(" bai 1 ");
            Console.WriteLine(" nhap chieu dai cua hcn = ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine(" nhap chieu rong cua hcn = ");
            b = float.Parse(Console.ReadLine());

            s = a * b;
            c = (a + b) * 2;
            Console.WriteLine("s = " +s);
            Console.WriteLine(" c = " +c);
            Console.ReadKey();
        }
    }
}
