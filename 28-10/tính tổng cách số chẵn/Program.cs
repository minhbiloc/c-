using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tính_tổng_cách_số_chẵn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so a");
          int tong = 0;
            int a = int.Parse(Console.ReadLine());
            
                if ( a %2 ==0)
                {
                for (int i = 0; i <= a; i += 2)
                          {
                    tong += i;
                         }
                Console.WriteLine($"tong cac so chan tu o den {a} la " + tong);
            }
              
                else
                {
                Console.WriteLine("toi khong tinh tong so le , bye bye");
              
                }
            
         
            Console.ReadKey();
        }
    }
}
