using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong_trình_chia_hết_3_từ_10_đến_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <=50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write($" {i}" + ""); // la no xuất trên cùng 1 hàng còn writeline xuống dòng
                }
            }
            Console.ReadKey();
        }
            
    }
}
