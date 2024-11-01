using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tạo_1_list_nhập_n_phần_từ_bàn_phím
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(" nhập số phần tử n :");
            int n =int.Parse(Console.ReadLine());
            Random r = new Random();
            List<int> ds = new List<int>();
            for (int i = 0; i < n; i++)
            {
                ds.Add(r.Next(1,101));
            }
            Console.WriteLine(" danh sách ngẫu nhiên vừa tạo ra là : ");
            foreach (int i in ds)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
