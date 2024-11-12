using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phanso
{
    internal class PhanSo
    {
        public int TuSo {get; set;}
         public int MauSo {get; set;}

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
            Console.WriteLine(TuSo + "/" +MauSo);
        }
        public int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        public void ToiGian( ref  PhanSo c)
        {
            int ucln = UCLN(c.TuSo,c.MauSo);
            TuSo/= ucln;
            MauSo/= ucln;
        }
        public PhanSo Cong (PhanSo b)
        {
            TuSo *= b.MauSo;
            b.TuSo *= MauSo;
             PhanSo c = new PhanSo(TuSo + b.TuSo, MauSo * b.MauSo);
           ToiGian(ref c);
            return c;
            
        }
        public PhanSo Tru(PhanSo b)
        {
            TuSo *= b.MauSo;
            b.TuSo *= MauSo;
            PhanSo c = new PhanSo(TuSo - b.TuSo, MauSo * b.MauSo);
            ToiGian(ref c);
            return c;

        }
        // khởi tạo giá trị truyền vào
        public PhanSo(int tuSo, int mauSo)
        {
            this.TuSo = tuSo;
            this.MauSo = mauSo;
           
            
        }
        // gán luôn giá trị
        public PhanSo()
        {
            this.TuSo = 8;
            this.MauSo = 6;
        }
    }
        
}
