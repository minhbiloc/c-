using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace mảng_1_chiều
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // mảng là tập hợp các đối tượng có cùng kiểu dữ liệu 
            //chúng có kích thước không cố định không thể thay đổi
            // mảng dùng để gom các đối tượng có cùng chất lại giúp code gọn hơn
            // khai báo mảng
            int[] stt; // khai báo mảng
            string[] ten;
            stt = new int[2]; // khởi tạo mảng
            ten = new string[3];
            int[] mang = new int[2];
            foreach (int i in stt)
            {
                Console.WriteLine(i);
            }
            // 3.gán giá trị cho mảng
            int[] mang2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("mảng 2 là ");
            Console.WriteLine("3.");
            foreach (int i in mang2)
            {

                Console.Write(+i + " ");
            }
            //4. khởi tạo mạng ngẫu nhiên
            Console.WriteLine("");
            Console.WriteLine("4.");
            Random r = new Random();
            int[] mang3 = { r.Next(51), r.Next(61) }; // random chạy từ 0 den 50 phần tử t2 chạy từ 0 den 60
            Console.WriteLine("mảng 2 là ");
            foreach (int i in mang3)
            {

                Console.Write(+i + " ");
            }
            //7. length kiểm tra độ dài
            Console.WriteLine("");
            Console.WriteLine("7.");
            int dai = mang3.Length;
            Console.WriteLine(dai);
           
            //8. truy xuất phần tử qua index
            Console.WriteLine("");
            Console.WriteLine("8.");
            int[] mang4 = { 1, 3, 5 };
            Console.WriteLine(mang4[0]);
            Console.WriteLine(mang4[2]);
            Console.WriteLine(mang4[mang4.Length-1]); // muốn tìm phần tử cuối thì dùng length -1
                                                      //9.thay dổi giá trị phần tử mạng bằng cách gọi index
            Console.WriteLine("");
            Console.WriteLine("9.");
            int[] mang5 = { 1, 3,4, 5,6 };
            mang5[1] = 100; // thay thế giá trị tại 1 thành 100
            Console.WriteLine("sau khi thay đổi giá trị là ");
            foreach (int i in mang5)
            {

                Console.Write("" +i + " ");
            }
            
            //10 .duyệt mảng for
            Console.WriteLine("");
            Console.WriteLine("10.");
            int[] mang6 = { 1, 23, 5, 7, 87, 3 };
            for (int i = 0; i < mang6.Length; i++)
            {
                Console.Write(mang6[i] + " ");
            }
            //12. phép gắn mảng 
            Console.WriteLine("");
            Console.WriteLine("12.");
            int[] mang8 = { 1, 4, 6, 8, 3, 2 };
            int[] mang9 = mang8;
            mang8[0] = 100;
            Console.WriteLine("mảng 8 sau thay doorii tại vị trí index 0 là :" + mang8[0]);
            Console.WriteLine("mảng 8 sau thay doorii tại vị trí index 0 là :" + mang9[0]);

            // 13. copyto
            Console.WriteLine("");
            Console.WriteLine("13.");
            int[] mang10 = { 100, 200, 300, 400, 500 };
            int[] mang11 = { 1, 23, 4, 5, 6 ,4 ,7,8};
            mang10.CopyTo(mang11,2); // coppy từ 10 vào 11 và đè từ index 2
            Console.WriteLine("sau khi thay đổi giá trị là ");
            foreach (int i in mang11)
            {

                Console.Write("" + i + " ");
            }

            // 14.copy

            Console.WriteLine("");
            Console.WriteLine("14.");

            int[] mang12 = { 100, 200, 300, 400, 500 };
            int[] mang13 = new int[4];
            Array.Copy(mang12, mang13, 4); //coppy mảng 12 vào mảnh 13 và lấy 4 phần tử

            Console.WriteLine("sau khi thay đổi giá trị là ");
            foreach (int i in mang13)
            {

                Console.Write("" + i + " ");
            }

            //15 .clone (tạo 1 mảng mới y sì mảng cũ)
            Console.WriteLine("");
            Console.WriteLine("15.");
            int[] mang14 = { 1, 3, 4, 5, 6, 7 };
            int[] mang15 = (int[])mang14.Clone();
            Console.WriteLine("mang15 là ");
            foreach (int i in mang15)
            {

                Console.Write("" + i + " ");
            }
            //16 Reverse :đảo ngược mảng
            Console.WriteLine("");
            Console.WriteLine("16.");
            int[] mang16 = { 1, 3, 5, 7, 8, 9, 10, 11 };
            Array.Reverse(mang16);
            Console.WriteLine("mang16 là ");
            foreach (int i in mang16)
            {

                Console.Write("" + i + " ");
            }

            //17. array.sort() sắp xếp mảng tăng dần
            Console.WriteLine("");
            Console.WriteLine("17.");
            int[] mang17 = { 1, 3,4,6,8,9,10,11 };
            Array.Sort(mang17);

            Console.WriteLine("mang17 là ");
            foreach (int i in mang17)
            {

                Console.Write("" + i + " ");
            }
            Console.ReadLine();
        }

        }
}
