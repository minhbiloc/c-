using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tim_tat_ca_so_hoan_thien_tu_1_den_1000
{
    internal class Program
    {
        static void Main(string[] args)
        {// 6 = 1+2 +3
         // nhap vao 1 so , kiem tra xem so do co phai so hoan hao k

          
            for (int n = 1; n <= 1000; n++)
            {
                int tong = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                        tong += i;
                    // kiem tra uoc
                }
                if (tong == n)
                    Console.WriteLine($"{n} la so hoan hao");
            }
            Console.ReadKey();
        }
       
    }
}
