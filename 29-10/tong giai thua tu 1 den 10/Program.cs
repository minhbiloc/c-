using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tong_giai_thua_tu_1_den_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                n *= i;// là tính giai thừa rồi
                sum += n;// tổng của n
            }
            Console.WriteLine("tong = " +sum);
            Console.ReadKey();
        }
    }
}
