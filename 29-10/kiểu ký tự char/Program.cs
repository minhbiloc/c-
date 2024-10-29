using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiểu_ký_tự_char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1 = 'A';// sử dụng nháy đơn đây là khai báo chuỗi , đây là kí tự
            Console.WriteLine(ch1);
            Console.WriteLine(ch1.GetTypeCode().ToString());// kiểm tra dữ liệu

            char ch2 = (char)64;// đẩy số nguyên trong bảng mã ASCII
            Console.WriteLine(ch2.GetTypeCode().ToString());
            Console.WriteLine(ch2);
            // chuyển kiểu char cho dữ liệu nhập vào
            char ch4 = char.Parse("b");
            Console.WriteLine(ch4);
            Console.WriteLine(ch4.GetTypeCode().ToString());
            // chuyển đổi kiểu dữ liệu
            char ch5 = Convert.ToChar("d"); 
            Console.WriteLine(ch5);
            Console.WriteLine(ch5.GetTypeCode().ToString());

            // so sánh 2 kí tự (CompareTo)
            char ch7 = 'a';
            char ch8 = 'b';
            char ch9 = 'c';
            char ch10 = 'l';
            char ch11 = 'a';
            Console.WriteLine(ch7.CompareTo(ch8));
            Console.WriteLine(ch8.CompareTo(ch7));
            Console.WriteLine(ch10.CompareTo(ch9));

            // so sánh 2 kí tự (Equals) => trả về true hay false
            Console.WriteLine(ch7.Equals(ch8));
            Console.WriteLine(ch7.Equals(ch11));

            // các phương thức - Char method in c#

            // kiểm tra có phải là chữ số hay k
            Console.WriteLine(Char.IsDigit('2'));
            // kiểm tra chữ cái (không phân biệt hoa hay thường)
            Console.WriteLine(Char.IsLetter('C'));
            //kiểm tra khoảng trắng (space)
            Console.WriteLine(Char.IsWhiteSpace(' '));
            // kiểm tra chữ viết thường
            Console.WriteLine(Char.IsLower('a'));
            // kiểm tra chữ viết hoa 
            Console.WriteLine(Char.IsUpper('B'));
            // chuyển sang in hoa
            Console.WriteLine(Char.ToUpper('a'));
            // chuyển từ in hoa sang thường
            Console.WriteLine(Char.ToLower('a'));
            Console.ReadKey();
        }
    }
}
