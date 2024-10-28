using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace làm_bài_tập_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a  ;
            Console.WriteLine("nhập số để tìm chương trình");
            Console.WriteLine("1. tìm theo tên");
            Console.WriteLine("2. tìm theo tác giả");
            Console.WriteLine("3. tìm theo nhà xuất bản");
            Console.WriteLine("4. tìm theo tiêu đề");
            Console.WriteLine("mời bấm phím để lựa chọn");
            a = int.Parse(Console.ReadLine());
            switch (a )
            {
                case 1:

                    Console.WriteLine("1 .tìm kiếm theo tên");
                    break;

                case 2:
                    Console.WriteLine("2. tìm theo tác giả");
                    break ;
                case 3:
                Console.WriteLine("3. tìm theo nhà xuất bản");
                    break;
                case 4:
                    Console.WriteLine("4. tìm theo tiêu đề");
                    break;
                default:
                    Console.WriteLine("mời bấm phím để lựa chọn");
                    break;
                

            }
            Console.ReadLine();
        }
    }
}
