using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();// cú pháp tạo ra 1 đối tượng có thẻ tạo ra 1 số ngẫu nhiên
            // (begin, sát end) begin k nhập , thì mặc đụng begin = 0
            int soNgauNhien = rd.Next(1,2); // 50-100
            Console.WriteLine(" day ra so ngau nhien " + soNgauNhien);  
            // muốn lấy số ngẫu nhiên nằm trong đoạn (0,1)
            double k2 = rd.NextDouble();// lấy đoạn từ 0 đến sát 1 không nhảy đến giá trị 1
            Console.WriteLine(" so ngau nhien 2 la " + k2);

            // 1.2353453 
            double k3 = k2 + soNgauNhien;// cách lấy có dấy phẩy
            Console.WriteLine("so ngau nhien tu 1 den 2 = "  + k3);
            // cánh 2
            double k4 = k2 * 10;
            Console.WriteLine(k4);

            Console.ReadKey();
        }
    }
}
