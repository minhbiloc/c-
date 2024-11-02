using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("user1", "123456");
            dic.Add("user2", "123456");
            dic.Add("user3", "123456");
            dic.Add("user4", "123456");
            dic.Add("user5", "123456");
            // duyệt dic
            foreach (KeyValuePair<string, string> pair in dic)
            
                {
                    Console.WriteLine(pair);
                }
                // 9. Chương trình yêu cầu nhập vào username và pass
                Console.WriteLine(" mời nhập vào username : ");
                string user = Console.ReadLine();
                Console.WriteLine(" mời nhập vào password : ");
                string mk = Console.ReadLine();
                // check user có tồn tại 
                if (dic.ContainsKey(user) == false)
                {
                    Console.WriteLine(" user không tồn tại");
                }
                else
                {
                    if (dic[user] == mk)
                        Console.WriteLine(" đăng nhập thành công");
                    else
                    {
                        Console.WriteLine(" Sai mật khẩu");
                    }
                }
            

            Console.ReadLine();
        }
    }
}
