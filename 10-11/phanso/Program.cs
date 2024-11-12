using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phanso
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.OutputEncoding = Encoding.UTF8;
            PhanSo a = new PhanSo(3,7);
            PhanSo b = new PhanSo(4,9);
           
            PhanSo c = a.Cong( b);
            PhanSo h = a.Tru(b);
            c.InPhanSo();
            h.InPhanSo();
            PhanSo d = new PhanSo();
            PhanSo e = new PhanSo();

            Console.WriteLine("Nhập phân số thứ nhất:");
            d.NhapPhanSo();

            Console.WriteLine("Nhập phân số thứ hai:");
           e.NhapPhanSo();

            PhanSo tong = d.Cong(e);
            PhanSo tru = d.Tru(e);

            Console.Write("Tổng của hai phân số là: ");
            tong.InPhanSo();
            Console.Write("Trừ của hai phân số là: ");
            tru.InPhanSo();

            Console.ReadKey();
        }
    }
}
