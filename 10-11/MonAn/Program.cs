using MonAn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class MonAn
{
    private string Ten;

    public MonAn(string ten)
    {
        Ten = ten;
    }

    public override string ToString()
    {
        return Ten;
    }

}
internal class SoPhuc
{
    private double PhanThuc;
    private double PhanAo;
    public SoPhuc(double phanThuc, double phanAo)
    {
        PhanThuc = phanThuc;
        PhanAo = phanAo;
    }

    public override string ToString()
    {
        return $"{PhanThuc} + {PhanAo}i";
    }
}
internal class PhanSo
{
    public int TuSo { get; set; }
    public int MauSo { get; set; }
    public void NhapPhanSo()
    {
        Console.Write("Nhập tử số: ");
        TuSo = int.Parse(Console.ReadLine());
        Console.Write("Nhập mẫu số: ");
        MauSo = int.Parse(Console.ReadLine());

        if (MauSo == 0)
        {
            Console.WriteLine(" mẫu khác 0 nên ta gán mẫu số là 1.");
            MauSo = 1;
        }
    }
    public void InPhanSo()
    {
        Console.WriteLine(TuSo + "/" + MauSo);
    }
}
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
namespace MonAn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            menu menu = new menu();
            int choice;
            do
            {


                Console.Clear();
                Console.WriteLine("Chương trình quản lý:");
                Console.WriteLine("1. Nhập món ăn");
                Console.WriteLine("2. Nhập phân số");
                Console.WriteLine("3. Nhập số phức");
                Console.WriteLine("4. In danh sách");
                Console.WriteLine("0. Thoát");
                Console.Write("Lựa chọn của bạn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        menu.NhapMonAn();
                        break;
                    case 2:
                        menu.NhapPhanSo();
                        break;
                    case 3:
                        menu.NhapSoPhuc();
                        break;
                    case 4:
                        menu.InDanhSach();
                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }

            } while (choice != 0);
        }
    }
}
