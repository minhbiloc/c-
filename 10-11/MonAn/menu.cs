using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAn
{
    internal class menu
    {


        static List<MonAn> danhSachMonAn = new List<MonAn>();
        static List<SoPhuc> danhSachSoPhuc = new List<SoPhuc>();
        static List<PhanSo> danhSachPhanSo = new List<PhanSo>();

        public void MonAn()
        {

        }
        public void NhapMonAn()
        {
            Console.Write("Nhập tên món ăn: ");
            string ten = Console.ReadLine();
            MonAn monAn = new MonAn(ten);
            danhSachMonAn.Add(monAn);
            Console.WriteLine("Đã thêm món ăn vào danh sách.");
        }
        public void NhapPhanSo()
        {
            PhanSo phanSo = new PhanSo();
            phanSo.NhapPhanSo();
            danhSachPhanSo.Add(phanSo);
            Console.WriteLine("Đã thêm phân số vào danh sách.");
        }

        public void NhapSoPhuc()
        {
            Console.Write("Nhập phần thực: ");
            double phanThuc = double.Parse(Console.ReadLine());
            Console.Write("Nhập phần ảo: ");
            double phanAo = double.Parse(Console.ReadLine());
            SoPhuc soPhuc = new SoPhuc(phanThuc, phanAo);
            danhSachSoPhuc.Add(soPhuc);
            Console.WriteLine("Đã thêm số phức vào danh sách.");
        }
        public void InDanhSach()
        {
            Console.Clear();
            Console.WriteLine("Danh sách Món ăn:");
            foreach (var monAn in danhSachMonAn)
                Console.WriteLine(monAn);

            Console.WriteLine("\nDanh sách Số phức:");
            foreach (var soPhuc in danhSachSoPhuc)
                Console.WriteLine(soPhuc);

            Console.WriteLine("\nDanh sách Phân số:");
            foreach (var phanSo in danhSachPhanSo)
                phanSo.InPhanSo();

            TroVeMenuChinh();
        }
        public void TroVeMenuChinh()
        {
            Console.WriteLine("\nNhấn phím bất kỳ để trở về menu chính...");
            Console.ReadKey();
        }
    }

   
}




