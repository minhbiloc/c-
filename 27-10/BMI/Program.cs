using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
           float chieuCao, canNang;
            Console.Write("Nhập vào chiều cao (m): ");
            chieuCao = float.Parse(Console.ReadLine());

            Console.Write("Nhập vào cân nặng (kg): ");
            canNang = float.Parse(Console.ReadLine());

            float BMI = canNang / (chieuCao * chieuCao);
            Console.WriteLine("BMI = " + BMI);

            if (BMI < 15)
                Console.WriteLine("Thân hình quá gầy");
            else if (BMI >= 15 && BMI < 16)
                Console.WriteLine("Thân hình gầy");
            else if (BMI >= 16 && BMI < 18.5)
                Console.WriteLine("Thân hình hơi gầy");
            else if (BMI >= 18.5 && BMI < 25)
                Console.WriteLine("Thân hình bình thường");
            else if (BMI >= 25 && BMI < 30)
                Console.WriteLine("Thân hình hơi béo");
            else if (BMI >= 30 && BMI < 35)
                Console.WriteLine("Thân hình béo");
            else
                Console.WriteLine("Thân hình quá béo");

            Console.ReadKey();
        }
    }
}
