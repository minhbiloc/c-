using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ví_dụ_về_in_hoa___số___space
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int demSo = 0, demChuThuong = 0, demInHoa = 0, demSpace = 0; 
            string chuoi = "Tôi tên là minh 1";
            char[] lst = chuoi.ToCharArray(); // khai báo lst đây là chuyển từ chuỗi sang 1 mảng
             // duyệt từ kí tự c trong lst 
            foreach (char c in lst)
            {
                // Console.WriteLine(c);
                if (char.IsDigit(c))
                    demSo++;
                else if (char.IsLower(c))
                    demChuThuong++;
                else if (char.IsUpper(c))
                    demInHoa++;
                else if (char.IsWhiteSpace(c))
                    demSpace++;
            }
            Console.WriteLine($"chuỗi có {demSo} kí tự số");
            Console.WriteLine($"chuỗi có {demChuThuong} kí tư chữ thường");
            Console.WriteLine($"chuỗi có {demInHoa} kí tư in hoa");
            Console.WriteLine($"chuỗi có {demSpace} kí tư khoảng trắng");
            Console.ReadLine();
        }
    }
}
