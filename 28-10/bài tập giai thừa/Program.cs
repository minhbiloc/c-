using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_giai_thừa
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //vòng forr
            // ví dụ 5! = 5*4*3*2*1
            int gt = 1;
            Console.WriteLine("moi nhap vao so nguyen n");
            int n = int.Parse(Console.ReadLine());

           for (int i = 1; i <=n; i++)
            
                {    
                gt *= i; // gt = gt*i
                 
                }
            Console.WriteLine($"giai thua {n} = {gt}");
            Console.WriteLine("-----------------------------------------");
            //vòng while
            int u = 1;
            int gt1 = 1;
            Console.WriteLine("moi nhap vao so nguyen v");
            int v = int.Parse(Console.ReadLine());
            while (u <= v)
            {
                gt1*= u;
                u ++;
               
            }
            Console.WriteLine($"giai thua {v} = {gt1}");

            Console.ReadLine();
        }

    }

}
