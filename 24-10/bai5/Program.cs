using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 115;
            Console.WriteLine(" kieu du lieu cua x la {0}" , x.GetType().ToString());
          
            var y = "Minh";

            Console.WriteLine(" kieu du lieu cua y la {0}", y.GetType().ToString());
            
            var k = 8.8;
            Console.WriteLine(" kieu du lieu cua k la {0}", k.GetType().ToString());
            Console.ReadKey();
        }
    }
}
