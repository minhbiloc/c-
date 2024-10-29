using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime homnay = DateTime.Now;
            Console.WriteLine("hom nay ngay " + homnay);
            DateTime  birthday = new DateTime(2003 , 12, 01);
            Console.WriteLine(" ngay thang nam sinh cua ban la " + birthday.ToString("dd/MM/yyyy"));
            Console.WriteLine( " ngay sinh cua ban la " + birthday.ToString("dd"));
            DateTime birthday1 = DateTime.Parse("12/01/2003");
            Console.WriteLine(" ngay thang nam sinh cua ban la" + birthday1.ToString("dd/MM/yyyy"));
            // viết chương trình cho người dùng nhập vào ngày tháng năm sinh
            Console.WriteLine(" moi nhap vao ngay thang nam sunhg ( thang/ngay/nam)");
            String s = Console.ReadLine(); 
            DateTime birthday3 = DateTime.Parse(s);
            Console.WriteLine(" ngay sinh ban cua nhap vao" + birthday3.ToString("dd"));
            Console.WriteLine(" thang sinh ban cua nhap vao" + birthday3.ToString("MM"));
            Console.WriteLine(" nam sinh ban cua nhap vao" + birthday3.ToString("yyyy"));
            Console.ReadKey();
        }
    }
}
