using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_vận_dụng_phép_toán
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i1 = 2;
            int i2 = 5;
            int i3 = (-3);
            float d1 = 2.0f;
            float d2 = 5.0f;
            float d3 = - 0.5f;
            int a =    i1 + (i2 * i3);
            int a1 =   i1 * (i2 + i3);
            float a2 =    (float) i1 /(i2 + i3);
            float a3 =  (float) i1/i2 +i3;
            float a4 =   3 + 4 +  (float) 5 / 3;
            int a5 =   (3 + 4 + 5) / 3;
            float a6 =   d1 + (d2 * d3);    
            float a7 =   d1 + d2 * d3;
            float a8 =   d1 / d2 - d3;
            float a9 =     d1 /  (d2 - d3);
            float a10 =  d1 + d2 +  d3 / 3;
            float a11 = (d1 +d2 +d3)/3;  
            float a12 =  d1 +d2 +   (d3 / 3);
            float a13 =  3 * (d1 + d2) * (d1 -d3);

            Console.WriteLine($"a = i1 + (i2 * i3) = {i1} + ({i2} * {i3}) = {a}");

            Console.WriteLine($"a1 = i1 * (i2 + i3) = {i1} * ({i2} + {i3}) = {a1}");

            Console.WriteLine($"a2 = i1 / (i2 + i3) = {i1} / ({i2} + {i3}) = {a2}");

            Console.WriteLine($"a3 = i1 / i2 + i3 = {i1} / {i2} + {i3} = {a3}");

            Console.WriteLine($"a4 = 3 + 4 + 5 / 3 = 3 + 4 + 5 / 3 = {a4}");

            Console.WriteLine($"a5 = (3 + 4 + 5) / 3 = (3 + 4 + 5) / 3 = {a5}");

            Console.WriteLine($"a6 = d1 + (d2 * d3) = {d1} + ({d2} * {d3}) = {a6}");

            Console.WriteLine($"a7 = d1 + d2 * d3 = {d1} + {d2} *{d3} = {a7}");

            Console.WriteLine($"a8 = d1 / d2 - d3 = {d1} / {d2} - {d3} = {a8}");

            Console.WriteLine($"a9 = d1 /  (d2 - d3) = {d1} / {d2} - {d3}  = {a9}");

            Console.WriteLine($"a10 = d1 + d2 - d3 / 3 = {d1} + {d2} - {d3} / 3 = {a10}");

            Console.WriteLine($"a11 = (d1 + d2 + d3) / 3 = ({d1} + {d2} + {d3}) / 3 = {a11}");

            Console.WriteLine($"a12 = d1 + d2 + (d3 / 3) = {d1} + {d2} + ({d3} / 3) = {a12}");

            Console.WriteLine($"a13 = 3 * (d1 + d2) * (d1 - d3) = 3 * ({d1} + {d2}) * ({d1} - {d3}) = {a13}");
            Console.ReadKey(); 
        }
    }
}
