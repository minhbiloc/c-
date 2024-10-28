using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhập_từ_1_đến_99
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine(" mời nhập vào số nguyên n từ 1- 99");
            n = int.Parse(Console.ReadLine()); // ép kiểu nguyên
            while (n >1 && n <99)
            {
                //Console.WriteLine(" nhập lại n , n chỉ được phép nhập từ 1 - 99");
                Console.WriteLine($"Bạn đã nhập xong giá trị n, n = {n}");
                n = int.Parse(Console.ReadLine());
            }
            //Console.WriteLine($"Bạn đã nhập xong giá trị n, n = {n}");
            Console.WriteLine(" nhập lại n , n chỉ được phép nhập từ 1 - 99");
            Console.ReadLine();
        }
    }
}
