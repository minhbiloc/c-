using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Khởi tạo các danh sách với các phần tử string và int
            List<string> ds1 = new List<string>(); // Danh sách các phần tử là string
            List<int> ds2 = new List<int>();       // Danh sách các phần tử là số nguyên

            // Khởi tạo danh sách với các phần tử ban đầu
            List<int> ds3 = new List<int>() { 1, 2, 3, 4, 5 };

            // In danh sách ds3
            Console.WriteLine("Danh sách ds3 là:");
            foreach (int i in ds3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Thêm phần tử ở cuối danh sách
            List<int> ds4 = new List<int>() { 1, 23, 5, 6, 4 };
            ds4.Add(100);

            // In danh sách ds4 sau khi thêm phần tử
            Console.WriteLine("Danh sách ds4 sau khi thêm phần tử 100:");
            foreach (int i in ds4)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Remove (object): Xóa phần tử đầu tiên nếu tìm thấy trong list
            List<int> ds5 = new List<int> { 2, 4, 6, 1, 3, 3 };
            ds5.Remove(4); // Nó sẽ xóa số 4 đầu tiên tìm thấy
            Console.WriteLine("Danh sách ds5 là:");
            foreach (int i in ds5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Count: Đếm số phần tử trong danh sách
            List<int> ds6 = new List<int>() { 6, 5, 76, 3, 3 };
            Console.WriteLine("Số phần tử trong ds6: " + ds6.Count);

            // Clear: Xóa toàn bộ phần tử
            List<int> ds7 = new List<int>() { 6, 5, 76, 3, 3 };
            ds7.Clear();

            // AddRange: Thêm toàn bộ danh sách ds9 vào cuối ds8
            List<int> ds8 = new List<int>() { 6, 5, 76 };
            List<int> ds9 = new List<int>() { 53, 4 };
            ds8.AddRange(ds9);
            Console.WriteLine("Danh sách ds8 sau khi thêm ds9:");
            foreach (int i in ds8)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Contains: Kiểm tra xem phần tử có tồn tại trong danh sách không
            List<int> ds10 = new List<int>() { 6, 51, 76 };
            bool kq = ds10.Contains(6);
            Console.WriteLine("Danh sách ds10 có chứa 6 không? " + kq);

            // GetRange: Lấy danh sách con từ index chỉ định và count phần tử
            List<int> ds11 = new List<int>() { 6, 51, 76, 4, 7, 5 };
            List<int> ds12 = ds11.GetRange(1, 3);
            Console.WriteLine("Danh sách ds12 (lấy từ ds11):");
            foreach (int i in ds12)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // IndexOf: Trả về vị trí index của giá trị tìm thấy
            List<int> ds13 = new List<int>() { 6, 51, 76, 4, 7, 5 };
            int checkIndex = ds13.IndexOf(51);
            Console.WriteLine("Vị trí của 51 trong ds13: " + checkIndex);

            // Insert: Chèn thêm giá trị vào vị trí index chỉ định
            List<int> ds14 = new List<int>() { 6, 51, 76, 4, 7, 5 };
            ds14.Insert(0, 1000);
            Console.WriteLine("Danh sách ds14 sau khi chèn 1000 vào đầu:");
            foreach (int i in ds14)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // InsertRange: Chèn danh sách vào vị trí index của list gốc
            List<int> ds15 = new List<int>() { 6, 51, 76, 4, 7, 5 };
            List<int> ds16 = new List<int>() { 3, 4 };
            ds15.InsertRange(2, ds16);
            Console.WriteLine("Danh sách ds15 sau khi chèn ds16 vào vị trí thứ 2:");
            foreach (int i in ds15)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // RemoveAt: Xóa phần tử tại vị trí index chỉ định
            List<int> ds17 = new List<int>() { 6, 51, 76, 4, 7, 5 };
            ds17.RemoveAt(1);
            Console.WriteLine("Danh sách ds17 sau khi xóa phần tử tại vị trí 1:");
            foreach (int i in ds17)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // RemoveRange: Xóa các phần tử từ index và số lượng chỉ định
            List<int> ds18 = new List<int>() { 6, 51, 76, 4, 7, 5 };
            ds18.RemoveRange(1, 3);
            Console.WriteLine("Danh sách ds18 sau khi xóa từ vị trí 1, 3 phần tử:");
            foreach (int i in ds18)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Reverse: Đảo ngược danh sách
            List<int> ds19 = new List<int>() { 6, 51, 76, 4, 7, 5 };
            ds19.Reverse();
            Console.WriteLine("Danh sách ds19 sau khi đảo ngược:");
            foreach (int i in ds19)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Sort: Sắp xếp danh sách tăng dần
            List<int> ds20 = new List<int>() { 4,2,1 };
            ds20.Sort();
            Console.WriteLine("Danh sách ds20 sau khi sắp xếp tăng dần:");
            foreach (int i in ds20)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // BinarySearch
            int kq2 = ds20.BinarySearch(1);
           
            Console.WriteLine(kq2);
            //19. max min

            int kq3 = ds20.Max();
            Console.WriteLine("giá trị max là " + kq3);
            Console.ReadLine();
        }
    }
}
