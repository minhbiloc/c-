using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thay_màu_text_hiển_trị
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Yellow; // thay đổi màu ký tự
            Console.WriteLine("Chương trình tìm kiếm");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("1. Tìm kiếm theo tên ");
            Console.WriteLine("2. tìm kiếm theo tác giả");
            Console.WriteLine("3.tìm kiếm theo tác phẩm");
            Console.ReadLine();
        }
    }
}
