using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giải_phương_trình_bậc_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c ,denta ,x1,x2 ,x ;
            Console.WriteLine("nhap a = ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("nhap b = ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("nhap c = ");
            c = double.Parse(Console.ReadLine());

            denta = b * b - 4 * a * c;

            if (denta < 0)
            {
                Console.WriteLine("phuong trinh vo nghiem");
            }
            else if (denta == 0) {
                x = -b / (2 * a);
                Console.WriteLine("phuong trinh co nghiem kep x1 = x2 =" + x)  ;
            }
            else                    {
                Console.WriteLine("phuong trinh co 2 nghiem x1,x2");
                x1 = (-b + Math.Sqrt(denta)) / (2 * a);
                x2 = (-b - Math.Sqrt(denta)) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);    
                                    }
            Console.ReadLine();
        }
    }
}
