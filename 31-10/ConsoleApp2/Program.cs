using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine( " mời nhập vào số phần tử của mảng");
            int n = int.Parse( Console.ReadLine() );
            // khai báo mảng
            int[] mang  = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write(mang[i] + " ");

            }
            // nhập giá trị ngẫu nhiên
            Console.WriteLine(" mảng ngẫu nhiên là : ");
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
               mang[i] = r.Next(101);

            }
            // xuất mạng
            for (int i = 0; i < n; i++)
            {
                Console.Write(mang[i] + " ");

            }
            // dảng ngược mảng
            Array.Reverse(mang);
            Console.WriteLine();
            Console.WriteLine(" mảng đảo ngược  là : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mang[i] + " ");

            }
            Console.WriteLine();
            Array.Sort(mang);
            Console.WriteLine(" mảng sau khi sắp sếp  là : ");
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(mang[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("tổng các phần tử là");
            // tính tổng cách phần tử
            int tong = 0;
            foreach (int i in mang)
            {
                tong += i;
               
            }
            Console.WriteLine(tong);
            // tìm kiếm mảng
            Console.WriteLine(" mời bạn nhập vào số cần tìm "  );
            int so = int.Parse( Console.ReadLine() );
            int kq = Array.BinarySearch( mang, so );
            if ( kq == -1)
            {
                Console.WriteLine("không tìm thấy rồi ");

            }
            else
            {
                Console.WriteLine($"tìm thấy số {so} ở vị trí {kq}");
            }
            // tìm thông thường
            int demkq = 0;
            for (int i = 0; i < n; i++)
            {
                if ( mang[i] == so)
                {
                    Console.WriteLine($"tìm thấy {so} ở vị trí {i}");
                    demkq++;
                }
            }
            if ( demkq == 0)
            {
                Console.WriteLine("không tìm thấy giá trị đó");
            }
            Console.ReadLine();
        }
    }
}
