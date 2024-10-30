using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so hoc sinh trong lop ");
            int hs = int.Parse(Console.ReadLine());
            while (hs < 0)
            {
                Console.WriteLine("khong hop le , nhap lai so hoc sinh ");
                hs = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"trong lop co {hs} hoc sinh");
            double tong = 0;
            for (int i = 1; i <= hs; i++)
            {
                double diem = double.Parse(Console.ReadLine());
                if (diem >= 0 && diem <= 10)
                {
                    Console.WriteLine($" diem hoc sinh so {i} bang " + diem);

                }
                else
                {
                    Console.WriteLine("nhap sai , vui long nhap lai");
                }
                
                tong += diem;
            }
            double dtb = tong / hs;
            Console.WriteLine("dtb cua ca lop = " + dtb);
            if (dtb >=8.5)
            {
                Console.WriteLine(" xep loai xat sac");
            }
            else if (dtb >=7.0) {
                Console.WriteLine(" xep loai gioi");

            }
            else if(dtb>5.5) {
                Console.WriteLine(" xep loai kha");

            }
            else if(dtb>4.0) {
                Console.WriteLine(" xep loai trung binh");

            }
            else  {
                Console.WriteLine(" xep loai yeu");

            }
            
         string trongdtb = (dtb >= 5.0) ? "lop da dat yeu cau" : " lop  khong dat yeu cau";
            Console.WriteLine(trongdtb);   
            Console.ReadLine();
        }
    }
}
