using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nhập vào 1 số , kiểm tra chẵn hay lẻ bằng switch case
            Console.OutputEncoding = Encoding.UTF8;
            int a ,div ; // đây gọi  ra biến a
            Console.WriteLine("nhập và số a"); // dùng để in 1 thông báo ra màn hình consle
            a = int.Parse(Console.ReadLine()); // chuyển nó thành số nguyên và gán số nguyên cho giá trị a

            // case -- switch :
            switch (div = a % 2) // biến cần kiểm tra 
            {
                case 0: // khi div nhận giá trị 0 thì in ra số chẵn
                    Console.WriteLine($"số {a} là số chẵn");
                    break; // thoát khỏi switch case khi xong câu lệch trên
                    default: // trường hợp còn lại
                    Console.WriteLine($"số {a} là số lẻ ");
                    break;
            }
            Console.ReadLine();
        }
          
    }
}
