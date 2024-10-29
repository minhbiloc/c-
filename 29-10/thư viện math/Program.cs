using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thư_viện_math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pi = " + Math.PI);
            Console.WriteLine("kieu du lieu cua math.pi" +Math.PI.GetType().ToString());// xuất ra được kiểu ví dụ float int , double
                                                                                        // căn bậc 2
            int a = 4;
            Console.WriteLine( " can bac 2 cua so a la " + Math.Sqrt(a) );
            Console.WriteLine(" can bac 2 cua so a la " + Math.Sqrt(a).GetType().ToString());
            // lỹ thừa
            Console.WriteLine(" luy thua 2 cua 3 la " + Math.Pow(2,3));
            //max
            Console.WriteLine("max bang " + Math.Max(2, 3));
            //lam tròn
            float c = 3.34234f;
            Console.WriteLine("lam tron 2 chu so la " + Math.Round(c,2)); // Math.Round c và làm tròn mấy chữ số
            // từ đó radian = số độ muốn đổi * pi/180
            Console.WriteLine("sin 180 = " + Math.Sin(Math.PI));// 1 độ bằng  pi /180
            Console.ReadLine();
        }
    }
}
