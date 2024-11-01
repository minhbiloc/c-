using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace in_ra_có_bao_nhiêu_số_nhỏ_hơn_5_và_in_ra_vị_trí_indexx_các_số_đó
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập vào số phần tử n");
            int n = int.Parse(Console.ReadLine());
            List<int> ds = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($" nhập vào phần tử thứ {i+1} của dãy ");
                ds.Add(int.Parse(Console.ReadLine()));

            }
            // xuất ds
            Console.WriteLine(" danh sách vừa nhập là ");
            foreach (int i in ds)
            {
                Console.Write(i + " ");
                
            }
            Console.WriteLine();
            // 1 in ra có bao nhiêu nhỏ hơn 5
            int dem = 0;
            foreach (int i in ds)
            {
                if (i <5)
                    dem++;
            }
            Console.WriteLine($"có {dem} phần tử < 5 trong ds");
            // 2  in ra vị trí indexx các số đó
            Console.WriteLine("vị trí index của các số nhỏ hơn 5 tròng dãy là : ");
            for (int i = 0;i < ds.Count; i++)
            {
                if(ds[i] < 5)
                {
                    Console.WriteLine(i + " ");
                }    
            }    
            Console.ReadLine();
        }
    }
}
