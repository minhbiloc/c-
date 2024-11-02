using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khái_quá_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // khai báo đối tượng mới

            //SinhVien sinhVien1 = new SinhVien();
            //SinhVien sinhVien2 = new SinhVien();

            //Console.WriteLine(sinhVien1.MaSV);
            //Console.WriteLine(sinhVien1.TenSV);
            //sinhVien1.MaSV = 123456789;
            
            //Console.Write(sinhVien1.MaSV);
            // 1 tọa 1 đối tượng mới không truyền giá trị

            SinhVien sinhVien1 = new SinhVien();
            SinhVien sinhVien2 = new SinhVien();
            // xuất
            Console.WriteLine(sinhVien1.MaSV);
            Console.WriteLine(sinhVien2.MaSV);
            Console.WriteLine(sinhVien1.TenSV);
            Console.WriteLine(sinhVien2.TenSV);
            Console.WriteLine(" tên sinh viên : " +sinhVien1.TenSV);

            //// 2 . tạo 1 đối tượng có truyền vào giá trị ban đầu
            //SinhVien sinhVien3 = new SinhVien(3,"Nguyễn Văn Ba");
            //Console.Write( "tên sinh viên 3 là "+sinhVien3.TenSV);
            //// 3. sửa dữ liệu đối tượng
            //sinhVien3.TenSV = "hihi";
            //sinhVien3.MaSV = 1213;
            //Console.WriteLine("tên sinh viên 3 là " + sinhVien3.TenSV);
            //Console.WriteLine("tên sinh viên 3 là " + sinhVien3.MaSV);
            //// 4. phương thức Tostring
            //Console.WriteLine(sinhVien1.ToString());
            //Console.WriteLine(sinhVien3.ToString());
            //Console.WriteLine(sinhVien1);
            //Console.WriteLine(sinhVien3);

            //Service Method $ support Method
            SinhVien sinhVien3 = new SinhVien(3,"Nguyễn Văn Ba",20);
            // check điểm
            sinhVien3.XuatThongTin();
            Console.WriteLine(sinhVien1.Tong(1,2,3));
             // parametter List Method
               Console.WriteLine(sinhVien1.TBKetThucHocKy(5,7,8,4,3,6,7,8,6));
            Console.WriteLine(sinhVien1.TBKetThucHocKy(10, 3, 10, 10, 10, 6, 7, 8, 6));
           HocSinh hocSinh1 = new HocSinh();
            hocSinh1.Name = "tao";
            hocSinh1.Phone = "90xx";
            hocSinh1.Email = "tao@gmail.com";
            Console.WriteLine(hocSinh1);
            Console.ReadKey();
        }
    }
}
