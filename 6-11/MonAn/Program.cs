using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            MonAn monAn= new MonAn();
          
            Console.WriteLine("tên món ăn");
            monAn.TenMonAN = (Console.ReadLine());
            Console.WriteLine("giá bán" );
            monAn.GiaBan = int.Parse(Console.ReadLine());
            Console.WriteLine("giới thiệu" );
            monAn.GioiThieu = (Console.ReadLine());
            Console.WriteLine("nguyên liệu chính");
            monAn.NguyenLieuChinh = (Console.ReadLine());
            monAn.InThongTin();
            Console.ReadKey();

        }
    }
}
