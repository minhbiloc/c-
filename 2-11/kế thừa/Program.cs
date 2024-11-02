using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kế_thừa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            NhanVien nv1 = new NhanVien();
            nv1.TenNV = "nhân viên 1";
            nv1.MaNV = 1;
            Console.WriteLine("tên nhân viên là:" + nv1.TenNV + " MNV " +nv1.MaNV);
            Console.WriteLine("lương nhân viên 1 là " + nv1.TinhLuong());
            NhanVienHanhChinh hc1 = new NhanVienHanhChinh();
            hc1.TenNV = "hanh van chính";
            hc1 .MaNV = 2;
            Console.WriteLine("tên nhân viên là:" + hc1.TenNV + " MNV " + hc1.MaNV);
            Console.WriteLine("lương nhân viên hành chính là " + hc1.TinhLuong());
            NhanVienDiCa ca1 = new NhanVienDiCa();
            ca1.TenNV = " nguyen van ca";
            ca1.MaNV = 3;
            ca1.Ca = "ca ngày";
           
            Console.WriteLine("tên nhân viên là:" + ca1.TenNV + " MNV " + ca1.MaNV + "nhân viên đi làm  " + ca1.Ca);
            Console.WriteLine("tên nhân viên di ca la là:" + ca1.TenNV + " MNV " + ca1.MaNV + "nhân viên đi làm  " + ca1.Ca + ca1.TinhLuong());
            Console.WriteLine("************************");
            Console.WriteLine(nv1.ThuongDuCong(26));
            Console.WriteLine(hc1.ThuongDuCong(26));
            Console.WriteLine(ca1.ThuongDuCong(26));
            Console.ReadKey();
        }

    }
}
