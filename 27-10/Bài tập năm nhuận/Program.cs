using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_năm_nhuận
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" nhap vao nam ");
            int nam = int.Parse(Console.ReadLine());

            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))

                Console.WriteLine(" la nam nhuan  ");


            else
                Console.WriteLine(" lanam khong nhuan");
            Console.ReadKey();
        }
            
    }
}
