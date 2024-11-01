using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_list_bình_phương_xác_định_bao_nhiêu_phần_tử_lớn_hơn_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập vào số phần tử của ds là : ");
            int n = int.Parse(Console.ReadLine());
            List <int> ds = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"mời nhập vào phần tử thứ {i} cua danh sách");
                ds.Add(int.Parse(Console.ReadLine()));
            }
            //0. xuất list sau khi nhập
            Console.WriteLine(" List bạn vừa nhập là : ");
                foreach( int t in ds)
                {
                    Console.WriteLine(t );
                }
                //1. tạo ra 1 list mới bình phương
                List<double> ds2 = new List<double>();
                foreach( int t in ds)
                {
                    ds2.Add(Math.Pow(t, 2));
                }
                Console.WriteLine(" List2 bạn vừa nhập là : ");
                foreach (int t in ds2)
                {
                    Console.WriteLine(t);
                }
            
            // xác định vao nhiêu phần tử lớn hpwn 50
            int dem = 0;
            foreach( int t in ds)
            {
                if (t > 50)
                    dem++;
            }
            Console.WriteLine($"có {dem} phần tử lớn hơn 50 trong danh sách 2");

            Console.ReadLine();
        }
    }
}
