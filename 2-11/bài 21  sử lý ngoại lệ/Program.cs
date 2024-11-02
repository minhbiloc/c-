using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_21__sử_lý_ngoại_lệ
{
    internal class Program
    {

        static void NgoaiLe()
        {
            try
            {
                Console.WriteLine(" nhập ngày tháng năm sinh");
                string s = Console.ReadLine();
                DateTime birthday = DateTime.Parse(s);
                Console.WriteLine("ngày sinh của bạn là : " + birthday.ToString("dd/mm/yyyy"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("cảm ơn các bạn đã ghi");
            }
           
        }
        static void Ngoaile2()
        {
            Console.WriteLine(" mời nhập vào tử số : ");
            int tu =int.Parse(Console.ReadLine());
            Console.WriteLine(" mời nhập vào mẫu số:  ");
            int mau = int.Parse(Console.ReadLine());
            if (mau == 0)
            {
                throw new ArithmeticException(" lỗi mãu bằng 0");
            }
        }
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            // 1 xuất thông báo lỗi
            // tiếp tục chạy chương trình mà không làm gián đoạn , treo phần mền
            try
            {
                Ngoaile2();
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            NgoaiLe();
            Console.ReadLine();
        }
    }
}
