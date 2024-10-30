using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viết_chương_trình_chuyển_tin_nhắn_sang_mật_mã_bảng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string a = "adkhbfjhfcsd";
            string b = "dkjfsjgcfkbjgsfs";
            Console.WriteLine(" mời nhập vào chuỗi cần mã hóa");
            string chuoiInput = Console.ReadLine();//abc
            string chuoiOutput = "";
            foreach (char c in chuoiInput)
            {
                Console.WriteLine($"{c}");
                int indexKyTu = a.IndexOf(c);
                Console.WriteLine(b[indexKyTu]);
                chuoiOutput += b[indexKyTu];
            }
            Console.WriteLine(chuoiOutput);
         Console.ReadLine();
        }
    }
}
