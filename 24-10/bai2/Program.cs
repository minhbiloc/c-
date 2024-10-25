using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Console.OutputEncoding = Encoding.UTF8;
            int soluong = 0;// khởi tạo biến
            float diemtrungbinh = 9.5f;
            string name = "Minh";
            byte tuoi; // khai báo biến
          Console.WriteLine ("số lượng là :{0}",soluong);
            Console.WriteLine ("số lượng là : {0}, diem trung binh la : {1}", soluong,diemtrungbinh);

            Console.ReadKey();  
        }
    }
}
