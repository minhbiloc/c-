using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_quý
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap thang ");
            double thang = double.Parse(Console.ReadLine());
            if (thang == 1 || thang == 2 || thang == 3)
            {
                Console.WriteLine("day la quy 1");
            }
            else if (thang == 4 || thang == 5 || thang == 6)
            {
                Console.WriteLine("day la quy 2");
            }
            else if (thang == 7 || thang == 8 || thang == 9)
            {
                Console.WriteLine("day la quy 3");
            }
            else if (thang == 10 || thang == 11 || thang == 12)
            {
                Console.WriteLine("day la quy 4");
            }
            else
            {
                Console.WriteLine("thang khong hop le");
            }
            Console.ReadKey();
        }
    }
}
