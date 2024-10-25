using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_các_phép_so_sánh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" nhap so nguyen a ");
           float a = float.Parse(Console.ReadLine());
           
            Console.WriteLine($"Ban moi nhap so nguyen a = " + a);

            a += 3;
            Console.WriteLine($"a = " + a);

            a -= 5;
            Console.WriteLine($"a = " + a);


           a *= 2;
            Console.WriteLine($"a = " + a);
            
              a /= 9;

            Console.WriteLine($"a = " + a);

            a %= 5;
            Console.WriteLine($"a = " + a);

            int b = 2;
            a = a - (b + 7);
            Console.WriteLine($"a = " +a );
            Console.ReadKey();
        }
    }
}
