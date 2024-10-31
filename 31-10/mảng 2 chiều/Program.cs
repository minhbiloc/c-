using System;
using System.Text;

namespace Mang2Chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Mảng 2 chiều
            // Mảng 2 chiều hay ma trận là tập hợp nhiều mảng 1 chiều có cùng kích thước

            // Khởi tạo mảng
            int[,] arr = new int[3, 5]; // 3 hàng 5 cột

            // Khởi tạo và gán giá trị cụ thể cho mảng 2 chiều
            int[,] arr2 = { { 1, 2, 3 }, { 6, 5, 7 } };

            // Khởi tạo và gán giá trị ngẫu nhiên
            Random r = new Random();
            int soDong = 3;
            int soCot = 4;
            int[,] arr3 = new int[soDong, soCot];

            // Gán giá trị ngẫu nhiên cho các phần tử của mảng
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    arr3[i, j] = r.Next(51); // Giá trị ngẫu nhiên từ 0 đến 50
                }
            }

            // In các phần tử trong mảng ra màn hình
            Console.WriteLine("Mảng 2 chiều arr3:");
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
