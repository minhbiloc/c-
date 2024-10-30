using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_tổng_tbc_chuỗi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String strl = "English = 78 Science = 83 Math = 68 History = 65";
            string[] lst = strl.Split(' ');
            string strSo = "";
            foreach (string s in lst)
            {
                //Console.WriteLine(s);
                foreach (char s2 in s)
                {
                   // Console.WriteLine(s2);
                    if (char.IsDigit(s2))
                    {
                        strSo += s + " ";
                        break;
                    }
                }
            }
            Console.WriteLine(strSo);
            strSo = strSo.Trim(); // xóa khoảng trắng
            // tách strSo theo space
            string[] lst2 = strSo.Split(' ');
            int tong = 0;
            foreach (string i in lst2)
            {
                Console.WriteLine(i);
                tong+= int.Parse(i); // ép kiểu nguyên cho thằng y ta mới cộng được

            }    
            Console.WriteLine("tong cac so can tim  " + tong);
            Console.ReadLine();   
        }
    }
}
