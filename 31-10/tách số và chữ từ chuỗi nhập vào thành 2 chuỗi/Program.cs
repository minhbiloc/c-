using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tách_số_và_chữ_từ_chuỗi_nhập_vào_thành_2_chuỗi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(" mời nhập vào 1 chuỗi");
            string chuoi = "";
            string so = "";

            string a = Console.ReadLine();
            foreach (char c in a) // duyệt từng kí tự c trong chuỗi s
            {
                // Console.WriteLine(c);
                if (char.IsDigit(c))
                    so += c;
                else if (char.IsLetter(c))
                    chuoi += c;
               
            }
            Console.WriteLine( "chỉ gồm số là " +so);
            Console.WriteLine( "chỉ gồm chữ cái lag" +chuoi);
            Console.ReadLine();
        }
    }
}
