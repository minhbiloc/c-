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
            string a = @"tôi chăm học
                        tôi chịu khó
                        tôi đẹp zai";
            // khai báo 1 mảnh
            string[] lst = a.Split(' ');
            int dem = 0;
            foreach (string s in lst)
            {
                //Console.WriteLine(s);
                if("tôi".Equals(s)) //kiểm tra tôi có trùng với s k rồi tăng biến đến lên 1
                    dem++; 
                
            }
            Console.WriteLine($"có {dem} từ tôi trong string a");
            Console.ReadLine();
        }
    }
}
