using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MonAn
{
    internal class MonAn
    {
        private string tenMonAn;
        private int giaBan;
        private string gioiThieu;
        private string nguyenLieuChinh;
        // tạo thuộc tính
        public MonAn() { 
            this.tenMonAn= string.Empty;
            this.giaBan = 0;
            this.nguyenLieuChinh= string.Empty;
            this.gioiThieu= string.Empty;
        }
        public string TenMonAN {
           get { return tenMonAn; }
            set { tenMonAn = value; }
        }
        public  int GiaBan {
            get { return giaBan; }
            set { giaBan = value; }
        }
        public string GioiThieu {
            get { return gioiThieu; } 
            set { gioiThieu = value; } 
        }
        public string NguyenLieuChinh
        {
            get { return nguyenLieuChinh; }
            set { nguyenLieuChinh = value; }
        }
        // Constructor khởi tạo
        public MonAn(string tenMonAN, int giaBan, string gioiThieu, string nguyenLieuChinh)
            {
            TenMonAN = tenMonAN;
            GiaBan = giaBan; 
            GioiThieu = gioiThieu;
            NguyenLieuChinh = nguyenLieuChinh;
            }
        // tạo phương thức
        public void InThongTin()
            
        {
            Console.WriteLine($"Món {TenMonAN} , {GioiThieu} , được làm từ các nguyên liệu chính {NguyenLieuChinh}");
        }
    }
}
