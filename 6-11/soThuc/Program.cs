using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soThuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SoThuc a = new SoThuc();
            SoThuc b = new SoThuc();
            SoThuc c = new SoThuc();
            double max = SoThuc.TimMax(a, b, c);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Căn bậc hai của a: " + a.TinhCanBacN());
            Console.WriteLine("Căn bậc hai của b: " + b.TinhCanBacN());
            Console.WriteLine("Căn bậc hai của c: " + c.TinhCanBacN());
            Console.ReadLine();
        }
        
    }
}
