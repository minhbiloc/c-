using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_tìm_tháng_bao_nhiêu_ngày
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap thang ");
            int thang = int.Parse(Console.ReadLine());
            if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
            {
                Console.WriteLine(" co 31 ngay");
            }
            else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                Console.WriteLine("co 30 ngay ");
            }
            else if (thang == 2)
            {
                Console.WriteLine(" nhap nam");
                int year = int.Parse(Console.ReadLine());
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine("co 29 ngay");

                }
                else
                {
                    Console.WriteLine("co 28 ngay");
                }
            }
            else { Console.WriteLine("thang khong hop le"); }
            Console.ReadLine();
        }
    }
}
