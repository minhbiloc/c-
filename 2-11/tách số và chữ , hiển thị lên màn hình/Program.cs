using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tách_số_và_chữ___hiển_thị_lên_màn_hình
{
    internal class Program
    {
        static void Main(string[] args)
        {//Dictionary<string, int> dic = new Dictionary<string, int>(){ {"A",1},{"B",2},{ "C",3},{ "D",2},{ "E",1},{ "F",4},{ "G",2},{ "H",4},{ "I",1},{ "J",8},{ "K",5},{ "L",1},{ "M",3},{ "N",1},{ "O",1},{ "P",3},{ "Q",10},{ "R",1},{ "S",1},{ "T",1},{ "U",1},{ "V",4},{ "W",4},{ "X",8},{ "Y",4},{ "Z",10} };
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<string, int> dic = new Dictionary<string, int>() { { "A", 1 }, { "B", 2 }, { "C", 3 }, { "D", 2 }, { "E", 1 }, { "F", 4 }, { "G", 2 }, { "H", 4 }, { "I", 1 }, { "J", 8 }, { "K", 5 }, { "L", 1 }, { "M", 3 }, { "N", 1 }, { "O", 1 }, { "P", 3 }, { "Q", 10 }, { "R", 1 }, { "S", 1 }, { "T", 1 }, { "U", 1 }, { "V", 4 }, { "W", 4 }, { "X", 8 }, { "Y", 4 }, { "Z", 10 } };

            // duyeenjt dic
            foreach(KeyValuePair<string,int> kvp in dic)
            {
                Console.WriteLine(kvp);
            }
            //1 tách chữ toList()
             Console.WriteLine(" sau khi tách là");
            List<string> ds = new List<string>();
            ds = dic.Keys.ToList();
           // Console.WriteLine("chữ cái sau khi tách là");
            foreach(string key in ds)
            {
                Console.Write(key.PadRight(3) );
            }
            Console.WriteLine();
            //1 tách số tolisst
            List<int> ds2 = new List<int>();
            ds2 = dic.Values.ToList();
            //Console.WriteLine("chữ số sau khi tách là");
            foreach (int i in ds2)
            {
                Console.Write( i.ToString().PadRight(3) );
            }
            Console.WriteLine();
            //tính tổng
            int tong = ds2.Sum();
            Console.WriteLine("tổng các chữ số là  " + tong);
            // chuyển đổi chuỗi sang số
            string s = "University of Technology and Education";
            string s2 = "";
            foreach(char c in s)
            {
                s2+= char.ToUpper(c);
                
            }
            Console.WriteLine("chuỗi sau khi viết hoa là " +s2);
            // chuyển đổi sang số
            string so = "";
            foreach(char c in s2)
            {
                if(c == ' ')
                    so += c;
                else
                    so += dic[c.ToString()];
            }
            Console.WriteLine(so);
            Console.ReadLine();
        }
    }
}
