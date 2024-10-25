using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            int x = 1;
            int y = 2;  
            float z = x/y; 
            Console.WriteLine( "giá trị của z là "+ z);
            float z2 =(float) x/y;
            Console.WriteLine("giá trị của z2 là : " + z2);
            byte a = 255;
            int b = a;
            Console.WriteLine(b);
            int k = 40000;
            byte l = (byte) k; // cố tình éo kiểu
               Console.WriteLine(l);    
            Console.ReadKey();
        }
    }
}
