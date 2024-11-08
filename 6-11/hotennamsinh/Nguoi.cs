using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotennamsinh
{
    internal class Nguoi
    {
        private int maSo;
        private string hoTen;
        private DateTime ngaySinh;
        private string ho;
        private string dem;
        private string ten;
        public int MaSo
        {
            get { return maSo; }
            set { maSo = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public string Dem
        {
            get { return dem; }
            set { dem = value; }
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public Nguoi() { 
        Console.Write("Nhập mã số: ");
            MaSo = int.Parse(Console.ReadLine());

            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            NgaySinh = DateTime.Parse(Console.ReadLine());}
        public Nguoi(int maSo, string hoTen, DateTime ngaySinh, string ho, string dem , string ten)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.ho = ho;
            this.dem = dem;
            this.ten = ten;

        }
        public void InThongTin()
        {
            Console.WriteLine($"{MaSo} có tên là {HoTen} sinh ngày {ngaySinh.ToString("dd/MM/yyyy")}");
        }
        
    }
}
