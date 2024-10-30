using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiem_tra_tinh_hop_le_mk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            Console.WriteLine("mời nhập vào mk( ít nhất 6 ký tự, ít nhất 1 chữ cái, ít nhất 1 chữ số): ");
            string mk = Console.ReadLine(); //123456a
            bool check = true;
            int demSo = 0, demKytu = 0;

            while (check == true)
            {
                foreach (char c in mk)
                {
                    if (char.IsDigit(c))
                        demSo++;
                    else if (char.IsLetter(c))
                        demKytu++;
                }

                Console.WriteLine(demSo);
                Console.WriteLine(demKytu);

                if (demKytu * demSo != 0 && mk.Length >= 6)
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("nhập lại mk ,( ít nhất 6 ký tự, ít nhất 1 chữ cái, ít nhất 1 chữ số)");
                    mk = Console.ReadLine();
                    check = true;
                }
            }
            Console.WriteLine("bạn đã thiết lập mật khẩu thành công , mk của bạn là " + mk);
            string login;
            int demLogin = 0;   

            Console.WriteLine("mời nhập vào mật khẩu đăng nhập: ");
            login = Console.ReadLine();
            while (true)
            {
                bool kq = mk.Equals(login);
                if (kq)
                {
                    Console.WriteLine("đăng nhập thành công");
                    break;

                }
                else
                {
                    demLogin++;
                    if (demLogin < 5)
                    {
                        Console.WriteLine($" nhập lại mk , nhập mật khẩu sai {demLogin}/5 lần");
                    }
                    else
                    {
                        Console.WriteLine(" bạn đã đăng nhập sai 5 lần , khóa đăng nhập");
                        break ;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
