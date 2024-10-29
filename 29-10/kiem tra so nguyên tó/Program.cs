using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiem_tra_so_nguyên_tó
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao so nguyen a>0");
            int a = int.Parse(Console.ReadLine());
            while (a < 0)
            {
                Console.WriteLine("nhap lai a , a phai lon hon 0");
                 a = int.Parse(Console.ReadLine());
            }
         int   denUoc = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    denUoc++;
            }
            if (denUoc == 2)
            {
                Console.WriteLine($" {a}la so nguyen to");
            }
            else
            {
                Console.WriteLine($" {a} khong phai so nguyen to");
            }
            Console.ReadKey();
        }
    }
}
