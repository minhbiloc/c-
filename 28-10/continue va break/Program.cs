using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continue_va_break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tong = 0;
            // tinh tong cac so tu 1- 5 (nhung o bao gom 3 ) 1+2+4+5
            for (int i = 0; i <= 5; i++)
            {
                if(i == 3) 
                    continue;// nếu i bằng 3 nó sẽ bỏ qua
                else
                {
                    Console.WriteLine("i = " +i);
                    tong +=i; // tong = tong +i
                } 
                  
            }
            Console.WriteLine("tong can tim la" +tong);
            Console.WriteLine("--------------------------------------------");
            int sum = 0;
            // tinh tong cac so tu 1- 5 (chỉ cộng đến 3 rồi thoat chương trình luôn)
            for (int i = 0; i <= 5; i++)
            {
                if (i == 3)
                    break; // đến 3 là nso ngắt luôn
                else
                {
                    Console.WriteLine("i = " + i);
                    sum += i; // tong = tong +i
                }

            }
            Console.WriteLine("tong can tim la" + sum);


            Console.ReadKey();
        }
    }
}
