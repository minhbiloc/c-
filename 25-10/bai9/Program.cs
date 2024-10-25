using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("moi nhap vao so nguyen n :");

            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"ban vua nhap vao so  " + n);
         
            if (n % 2 == 0)
            
                Console.WriteLine(  $"" + n + " là so chan");
                
            
            else
            
                Console.WriteLine( $"" + n +" là so le");
            
            Console.ReadKey();
        }

    }
}
