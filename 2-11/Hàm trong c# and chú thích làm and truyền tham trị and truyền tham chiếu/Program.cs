using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hàm_trong_c__and_chú_thích_làm_and_truyền_tham_trị_and_truyền_tham_chiếu
{
    internal class Program
    {
        /// <summary>
        /// Hàm này là để tính tổng nhé thím ơi
        /// </summary>
        /// <param name="x">nhập x nguyên nhé</param>
        /// <param name="y">nhập y nguyên nhé</param>
        /// <param name="z">nhập z nguyên nhé</param>
        /// <returns> nó return về tổng 3 số nhé</returns>
        static int Tong(int x, int y, int z )
        {
            return x + y + z;


        }
        // gia thừa
        static int TinhGiaiThua(int n)
            {
            int gt = 1;
            for (int i = 1; i <= n; i++)
                gt += i;
            return gt; }   

        // ví dụ static void
        static void XinChao(string m)
        {
            if (m=="nam")
                Console.WriteLine("xin chào mình là boy");
            if (m=="nu")
                Console.WriteLine("xin chào mình là girl");
        }
        // truyền tham trị : không thay đổi sau khi gọi hàm
        static void ThamTri(int a)
        {
            a = a + 1;
            Console.WriteLine("giá trị a trong hàm là: "+a );
        }
        // ref : truyền tham chiếu (truyền tham biến) : có thay đổi giá trị của biến sau khi gọi hàm
        static void ThamChieuRef (ref int b)
        {
            b = b + 1;
            Console.WriteLine(" b trong hàm là "+b );  
        }
        // out : truyền tham chiếu (truyền tham biến) : có thay đổi giá trị của biến sau khi gọi hàm
        static void ThamChieuOut(out int c)
        {
            c = 5;
            Console.WriteLine("giá trị của c trong hàm là "+ c );
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // hàm là 1 khối lệch thực hiện 1 công việc hoàn chỉnh (module)
            // hàm còn được gọi là chương trình con , phương thức , hành vi
            // hàm có thể gọi từ chườn trình chính (hàm main) hoặc từ 1 hàm khác
            // hàm 2 loại : trả về giá trị (có return)
            // không trả về giá trị : gọi là hàm thủ tục ( procedure)
            // công dụng : chia nhỏ phần việc của dự án
            // tái sử dụng : khi cần chỉ cần gọi lại chương trình con mà o cần phải viết lại
            int kq = Tong(1, 2, 3);
            Console.WriteLine("kq = " + kq);
            // xuất giai thừa
            int k = 3;
            int kq2 = TinhGiaiThua(k);
            Console.WriteLine("kq2 = " +kq2);
            XinChao("nam");
            int kq3 = Tong(7,8,9);
            //truyền tham trị
            int a = 1;
            Console.WriteLine("a trước khi gọi hàm là " +a);
            ThamTri(a);
            Console.WriteLine("a sau khi gọi hàm là " + a);

            // Truyền tham chiếu ( truyền than biến) ref
            // ref phải khởi tạo giá trị cho biến trước khi gọi hàm
            // int b ; // sẽ báo lỗi
            int b = 2;
            Console.WriteLine("b trước khi gọi hàm" + b);
            ThamChieuRef(ref b);
            Console.WriteLine("b sau khi gọi hàm " + b);

            int c ;
         
            ThamChieuOut(out c);
            Console.WriteLine("c sau khi gọi hàm " + c);
            Console.ReadKey();
        }
    }
}
