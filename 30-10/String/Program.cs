using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // khai báo chuỗi

            string chuoi = "Minh ne";
            Console.WriteLine(" chuoi ban vua nhap la " + chuoi);
            // Khai báo nguyên văn @ nếu không phảo dùng \\
            // kí tự            ý nghĩa
            //  \'               dấu nháy đơn
            //  \"                  dấu nháy kép
            //  \\                  dấu chéo
            //   \n                   xuống dòng
            //   \y                     tab ngang
            string chuoi2 = @":\minhday";
            Console.WriteLine(" chuoi ban vua nhap la " + chuoi2);
            string chuoi3 = "co nguoi noi rang :\" adc \" ";
            Console.WriteLine(chuoi3);
            string chuoi4 = "co nguoi noi rang : \n \" adc \" ";
            Console.WriteLine(chuoi4);
            // 4.chuyển đổi sang chuỗi
            int i = 1234;
            string chuoi5 = i.ToString(); // cách 1
            string chuoi6 = i + ""; // cách 2
            string chuoi7 = Convert.ToString(i); // cánh 3
            Console.WriteLine(chuoi7);
            Console.WriteLine(chuoi5);
            Console.WriteLine(chuoi6);
            Console.WriteLine(chuoi5.GetType().ToString());
            // 5.tách chuỗi thành các kí tự lẻ , cho vào 1 mảng
            string chuoi8 = "xinchao";
            char[] lst = chuoi8.ToCharArray();
            Console.WriteLine(lst.GetType().ToString());
            Console.WriteLine(lst);
            // 6.length : trả về độ dài của chuỗi
            string chuoi9 = "do dai chua chuoi";
            int j = chuoi9.Length;
            Console.WriteLine(j);
            Console.WriteLine(" ki tu thu 2 cua chuoi la " + chuoi9[1]);// lấy chữ cái của chuỗi bắt đầu chạy từ 0 trở đi
            Console.WriteLine(" ki tu thu 2 cua chuoi la " + chuoi9[j-3]); // từ cuối trở về
            // 7. so sánh chuỗi
            string chuoi10 = "12345a";
            string chuoi11 = "12345b";
            int sosanh = chuoi10.CompareTo(chuoi11);
            Console.WriteLine(sosanh);
            // 8.kiểm tra chuỗi con
            string chuoi12 = "avc";
            string chuoi13 = "afgvcavc"; // vì chuỗi có avc nên chuoi12 là con chuỗi13 
            bool l = chuoi13.Contains(chuoi12);
            Console.WriteLine(l);
            // 9. hàm Copyto
            string chuoi14 = "123456";
            char[] lst2 = new char[6];//khai báo mảng kí tự có tên mảng là  là lst2 kiểu dữ liệu là char có độ dài bằng 6 (6 phần tử)
            lst2[0] = 'a';
            lst2[1] = 'b';
            Console.WriteLine(lst2);
            chuoi14.CopyTo(1, lst2, 2, 4);// giải thích trong () lần lượt là: copy từ vị trí index 1 chuoi14 vào lst2 vào trị chí thứ 2 và coppy 4 kí tự của chuoi14 
            Console.WriteLine(lst2); // nó sẽ dc ab2345
            //10. hàm boolEndsWith(string value) 
            // kiểm tra xem chuỗi có kết thúc bnawfg chuỗi con hay không
            string chuoi15 = "ditimtinhyeu.mp3";
            bool kt = chuoi15.EndsWith("mp3"); // bool là kiểu dữ liệu kiểm tra xem đúng hay sai
            Console.WriteLine(kt);
            // 11 . Gán chuỗi theo string.Format
            string chuoi16;
            int n = 15;
            chuoi16 = string.Format($"n={n} và căng bậc 2 của n là " + Math.Sqrt(n));
            Console.WriteLine(chuoi16);
            Console.WriteLine($"n={n} và căng bậc 2 của n là "+  Math.Sqrt(n));// xuất cho người xem 1 lần
            // 12. hàm Equals
            //kiểm tra xem 2 chuỗi có bằng nhau hay k
            string chuoi17 = "hihi";
            string chuoi18 = "hihi";
            bool kt2 = chuoi17.Equals(chuoi18);
            Console.WriteLine(kt2);
            // 13. chèm thêm vào chuỗi string,Insert
            string chuoi19 = "123";
            string chuoi20 = "abc";
            chuoi19 = chuoi19.Insert(3,chuoi20);//// chèn từ vị trí số 3 nghĩa là sau 123 dc bằng 123abc
            Console.WriteLine(chuoi19);
            //14. indexOf 
            // kiểm tra vị trí xuất hiện đầu tiên của ký tự hoặc chuỗi , trả về -1 nếu không tìm thấy
            string chuoi21 = "213assafffsc";
            int kq4 = chuoi21.IndexOf('a');
            Console.WriteLine(kq4);
            Console.WriteLine(chuoi21.Length);
            Console.WriteLine(chuoi21[0]);
            Console.WriteLine(chuoi21[chuoi21.Length-1]);
            //15. LastIndexOf
            // giống indexOf nhưng trả về giá trị index xuất hiện cuối cùng
            string chuoi22 = "lahihia";
            int kq5 = chuoi22.LastIndexOf('a');
            Console.WriteLine(kq5);
            //16  remove(Index.count)
            // xóa đi count phần tử , từ phần vị trí start index
            string chuoi23 = "12456";
            Console.WriteLine(chuoi23);
            chuoi23 = chuoi23.Remove(1,2);// xúa từ vị trí index 1 và xóa đi 2 phần tử
            Console.WriteLine(chuoi23);
            // replace 
            // thay thế toàn bộ old bàng chuỗi new
            string chuoi24 = "abcde";
            chuoi24 = chuoi24.Replace("ab", "123");// thay thành 123de
            Console.WriteLine(chuoi24);
            // 18 . bool StartsWith
            // kiểm tra xem chuỗi có bắt đầu bằng chuỗi con hay không
            string chuoi25 = "ditimtinhyeudau.mp3";
            bool kt6 = chuoi25.StartsWith("ditim");
                Console.WriteLine(kt6);
            //19. substring 
            // trích lọc chuỗi con từ chuỗi ban đầu
            string chuoi26 = "123456";
            string chuoi27 = chuoi26.Substring(2, 3); //cắt chuỗi vị trí index 2 và xóa 3 kí tự ta dc 345
            Console.WriteLine(chuoi27);
            //20 .tolower(); trả về chữ thường
            // toUpper();  trả về chữ hoa
            string chuoi28 = "COn đi học về muộn hhahahaa";
            Console.WriteLine(chuoi28);
            chuoi28 = chuoi28.ToLower();
            Console.WriteLine(chuoi28);
            chuoi28 = chuoi28.ToUpper();
            Console.WriteLine(chuoi28);
            //21 Strim()
            // xóa toàn bộ khoảng trắng ở đầu và cuối không xóa ở giữa
            string chuoi29 = "                   abc              ";
            chuoi29 = chuoi29.Trim();
            Console.WriteLine(chuoi29);
            //22 strimend()
            string chuoi30 = "   dkjhfs    đ        ";
            chuoi30 = chuoi30.TrimEnd();// xóa khoảng trắng cuối đoạn
            Console.WriteLine(chuoi30);
            //23 strimstart()
            chuoi30= chuoi30.TrimStart();//xóa khoảng trắng đầu đoạn
            Console.WriteLine(chuoi30);
            //24 .split 
            //tách chuỗi trả về mảng
            string chuoi31 = @"moi \ hai \ ba \ bon";
            string[]lst3 = chuoi31.Split('\\');
            Console.WriteLine(lst3[0]);
            Console.WriteLine(lst3[1]);
            Console.WriteLine(lst3[2]);
            Console.WriteLine(lst3[3]);
            // 25 joint string 
            // nối các phần tử của 1 list thành 1 chuỗi
            string chuoi32 = string.Join("++", lst3);
            Console.WriteLine( "25. " +chuoi32);
            Console.ReadKey();
        }
    }
}
