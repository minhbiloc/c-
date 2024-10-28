using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forerach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lst = { 1, 3 ,5,7,8,10,12}; // lst là tên biến
            int thang;
            Console.WriteLine("nhap vao 1 thang trong nam:");
            thang = int.Parse(Console.ReadLine());
            foreach (int i in lst)  // chạy từ phần tử 1 i trong lst
            {
                Console.WriteLine( "i =" +i);
                if (thang == i )
                {
                    Console.WriteLine($"thang {i} có 31 ngay");
                    break;
                }    
            }
            Console.ReadKey();
        }
       
    }
}
