using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace in_ra_số_lớn_thứ_2_và_số_nhỏ_t2_tròn_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> ds = new List<int>() { 1,2,3,4,5,6};
            //Console.WriteLine("giá trị max là : " + ds.Max());
            List<int> ds2 = new List<int>() { 1, 2, 3, 4, 5, 6 };
        
            // xuất ds 2
            Console.WriteLine("ds 2 sau khi coppy là : ");
            ds2.Remove(ds2.Max());
            ds2.Remove(ds2.Min());
            foreach (int i in ds2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("giá trị max thứ 2 của ds là : " + ds2.Max());
            Console.WriteLine("giá trị min thứ 2 của ds  là : " + ds2.Min());
            // ỉn ra vị trí indexx dùng
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i]==ds2.Min())
                    Console.Write("vị trí indexx của số nhỏ  t2 tròng dãy là " +i);

            }
            Console.WriteLine();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i] == ds2.Max())
                    Console.Write("vị trí indexx của số max  t2 tròng dãy là " + i);

            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
