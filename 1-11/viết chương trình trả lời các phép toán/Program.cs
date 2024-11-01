using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viết_chương_trình_trả_lời_các_phép_toán
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<string> quest = new List<string>() { "2+5 +7 = ", "5+10 = ", "sqrt(16) = ", "12%2=", "5//2="  };
            List<int> traloi = new List<int>() { 14, 14, 4, 0, 4 };
            for (int i = 0; i < quest.Count; i++)
            {
                Console.WriteLine(quest[i]);
                Console.WriteLine();
                int ans=int.Parse(Console.ReadLine());
                if(ans == traloi[i])
                    Console.WriteLine("corect");
                else 
                    Console.WriteLine("wrong , the anwer is " + traloi[i]);
            }
            Console.ReadLine();
        }
    }
}
