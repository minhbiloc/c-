using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string hoTen;
            float diemToan;
            float diemVan;
            Console.WriteLine("Mời nhập tên vào : "); 
            hoTen = Console.ReadLine();

            Console.WriteLine("Mời nhập điểm toán : ");
            diemToan = float.Parse(Console.ReadLine()); // ép kiểu float để nhập vì data nhập vào luôn ghi nhận kiểu chuỗi (string)
            Console.WriteLine("Mời nhập điểm văn : ");
            diemVan = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Học sinh {0} có điểm toán là{1} , điểm văn là {2}", hoTen, diemToan,  diemVan);

            Console.ReadKey();
        }
    }
}
