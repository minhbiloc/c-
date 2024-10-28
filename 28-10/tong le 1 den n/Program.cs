using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tong_le_1_den_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tong = 0;
            int i = 1; 
            Console.WriteLine("nhap gia tri n ");
            int n = int.Parse(Console.ReadLine());
            while (i <=n) 
            {
                if (i == 3)
                {
                    i += 2;
                    continue;
                }
                tong += i;
                i += 2;
            }
            
            Console.WriteLine($" tong cac so le tu 1 den {n} bang " + tong);
            Console.ReadKey();
        }

    }
}
