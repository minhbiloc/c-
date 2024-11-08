using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soThuc
{
    internal class SoThuc
    {
        private double giaTri;

        public double GiaTri
        {
            get { return giaTri; }
            set { giaTri = value; }
        }
        public bool LaSoDuong
        {
            get { return giaTri > 0; }// get giá trị để đọc
        }
        //constructor đê khởi tạo giá trị
        public SoThuc()
        {
            Console.Write("Nhập giá trị cho số thực: ");
            giaTri = double.Parse(Console.ReadLine());

            while (giaTri <= 0)
            {
                Console.WriteLine("Giá trị phải lớn hơn 0. Vui lòng nhập lại.");
                Console.Write("Nhập giá trị cho số thực : ");
                giaTri = double.Parse(Console.ReadLine());
            }
        }

        public SoThuc(double giaTri)
        {
            this.GiaTri =giaTri;
        }

        public static double TimMax(SoThuc a , SoThuc b, SoThuc c)
        {
            return Math.Max(a.GiaTri, Math.Max(b.GiaTri, c.GiaTri));
        }
        public double TinhCanBacN()
        {
            return Math.Sqrt(giaTri);
        }
    
    }
}
