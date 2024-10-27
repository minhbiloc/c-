using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_toán_tử_3_ngôi_xếp_loại_học_lực
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diem;
            Console.WriteLine("nhap vao diem:");
            diem = int.Parse(Console.ReadLine());
            string hocluc = diem >= 8 ? "Gioi" : (diem < 8 && diem >= 6.5 ? "kha" : (diem < 6.5 && diem >= 5 ? "trung binh" : "yeu")) ;
            Console.WriteLine(hocluc);
            Console.ReadLine();
        }
    }
}
    