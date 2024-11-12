using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAn
{
    internal class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }
    public void NhapPhanSo()
        {
            Console.Write("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());

            if (MauSo == 0)
            {
                Console.WriteLine(" mẫu khác 0 nên ta gán mẫu số là 1.");
                MauSo = 1;
            }
        }
        public void InPhanSo()
        {
            Console.WriteLine(TuSo + "/" + MauSo);
        }
    }
}
