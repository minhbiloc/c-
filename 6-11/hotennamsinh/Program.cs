using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotennamsinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Nguoi hocsinh = new Nguoi();
            Console.Write("Nhập mã số: ");
            hocsinh.MaSo= int.Parse(Console.ReadLine());
            Console.Write("Nhập họ tên: ");
            hocsinh.HoTen = (Console.ReadLine());
            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            hocsinh.NgaySinh = DateTime.Parse(Console.ReadLine());
           
            hocsinh.InThongTin();
            Console.ReadKey();
        }
    }
}
