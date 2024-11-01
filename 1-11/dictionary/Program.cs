using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // dictionay là một collection lưu trữ dữ liệu dưới dạng cặp key và value
            // dùng để chứa 1 bảng biến đổi 1-1 giữ 2 tập hợp
            Dictionary<int , string > dic = new Dictionary<int , string>();
            // 2 khởi tạo và gán giá trị
            Dictionary<int, string> dic2 = new Dictionary<int, string>() { {1,"ihaha" }, {2,"lakaka" } };
            // key: biển số xe (kiểu string)
            // value : chức minh thư (int)
            Dictionary<string, int> dic3= new Dictionary<string, int>() { {"20h28411",082782 },{"17b1998",12484444 } };
            //4. add
            dic.Add(1, "hi văn ca");
            dic.Add(2, "hi văn ki");
            dic.Add(3, "va văn ka");

            //5 duyệt dic 
            foreach (KeyValuePair<int, string> kvp in dic) // kvp là tên biến

            {
                //Console.WriteLine(kvp);
                //Console.WriteLine(kvp.Key);// chỉ xuất ra key
                //Console.WriteLine(kvp.Value);// chỉ xuất ra value
                Console.WriteLine($" { kvp.Key} ,{ kvp.Value} ");
            }
            //6 dic.ContainsKey(2) kiểm tra xem 1key có tồn tại trong dic hay không
            // true , false có , k tồn tại
            bool kq = dic.ContainsKey(2);
            Console.WriteLine("kq bằng" + kq);
            //7 dic.Contrainvalue
            bool kq2 = dic.ContainsValue(" hi văn ca");
            Console.WriteLine("kq bằng value" + kq);
            //8. dic[key] lấy value từ key
            string name = dic[1];
            Console.WriteLine(name);
            //8.1 gán giá trị
            dic[1] = " đổi băn mới";
            Console.WriteLine(dic[1]);
            // 9 xóa phần tử
            dic.Remove(1);
            Console.WriteLine("dic sau xóa là ");
            
            foreach ( KeyValuePair<int, string> kvp in dic)
            {
                Console.WriteLine(kvp);
            }
            // . 10 dic.clear
            Console.WriteLine(" số  tr  xoa phần tử của dic là " + dic.Count);
            dic.Clear();
            Console.WriteLine(" số  xóa  sau phần tử của dic là "+  dic.Count);
            // 11 chuyển value dic => list
            Dictionary<string, int> dic4 = new Dictionary<string, int>() { { "20h28411", 082782 }, { "17b1998", 12484444 } };
            List <int> ds = new List <int>();
            ds= dic4.Values.ToList();
            Console.WriteLine("ds value là ");
            foreach(int i in ds)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //12. chuyển key sang list
            Dictionary<string, int> dic5 = new Dictionary<string, int>() { { "20h28411", 082782 }, { "17b1998", 12484444 } };
            List<string> ds2 = new List<string>();
            ds2 = dic5.Keys.ToList();
            Console.WriteLine("ds key là ");
            foreach (string key in ds2)
            {
                Console.Write(key + " ");
            }
            Console.WriteLine();
           
            Console.ReadLine();
        }
    }
}
