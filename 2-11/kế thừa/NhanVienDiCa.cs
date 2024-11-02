using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kế_thừa
{
    public class NhanVienDiCa: NhanVien
    {
        // khai báo thêm các thuộc tính ca ngày, ca đêm
        public string Ca {  get; set; }
        //phương thức tính lương của nhân viên đi ca
        public new double TinhLuong()
        {
            return base.TinhLuong()*1.05;//gọi lại giá trị của thằng cha

        }
    }
}
