using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace khái_quá_oop
{
    public class SinhVien
    {
        #region biến lớp // thu gọn code lại
        // khai báo biến lớp
        private int maSV;
        private string tenSV;
        private float diemThiDH;
        #endregion

        #region constructor
        // khởi tạo giá trị mặc định
        // khai báo constructor là hàm dùng để tạo giá trị cho đối tượng , khi đối tượng dc sinh ra ví dụ là public Sinhvien(){}
        // (gián giá trị mặc định cho đối tượng)
        public SinhVien()
        {
            this.maSV = 0;
            this.tenSV = " No name";
            this.diemThiDH = 0;

        }
        // khai báo constructor 
        // gán
        public SinhVien(int maSV, string tenSV,float diemThiDH)
        {
            this.maSV = maSV; // this là thay cho tên đối tượng tạo ra ví dụ sinhvien1 sinhvien2
            this.tenSV = tenSV;
            this.diemThiDH = diemThiDH;
        }
        #endregion 
        #region properties
        //properties
        // không truy xuất đượ bên ngoài
        //giúp ta có thể truy xuất xem sửa đổi dữ liệu 
        // vì chúng ra đã private nó rồi
        public string TenSV
        {
            get { return tenSV; } //get giá trị để đọc
            set { tenSV = value; } // sét giá trị
        }
        public int MaSV
        {
            set {  maSV= value; } //get giá trị để đọc
            get { return maSV; } // sét giá trị
        }
        public float DiemThiDH
        {
            get { return diemThiDH; }
            set { diemThiDH = value; }
        }
        // phương thức
        // truy xuất phương thức tenDoiTuong.TenPhuongThuc(); 
        // ví dụ Console.WriteLine(char.ToUpper(KyTu));
        #endregion
        #region các phương thức
        // string
        public override string ToString()
        {
            return this.MaSV+ "\t" + this.TenSV;
        }
        // support method
        // kiểm tra điều kiện nhập sinh viên mới
        private bool CheckDiemThiDH()
        {
            return (this.diemThiDH -21>=0);
        }

        //service method (xuất thông tin)
        public void XuatThongTin()
        {
            if(CheckDiemThiDH()==false)
                Console.WriteLine("điểm thi ddauij học <21, cần kiểm tra lại hs sv này");
            else
                Console.WriteLine(ToString());
        }
        // khác  nhau về signature((int x,int y)) và cùng tên phương thức( public int Tong)
        // tổng
        public int Tong(int x,int y)
        {
            return x + y;

        }
        public int Tong(int x, int y, int z)
        {
            return x + y + z ;

        }
        public double Tong(double x, double y, double z)
        {
            return x + y + z;

        }
        // parametter List Method
        //tính tổng điểm trung bình kết thúc học kỳ
        public float TBKetThucHocKy(params float[] mang )
        {
            float s = 0;
            foreach( float f in mang )
            {
                s += f;
            }    
            return (s/mang.Count());
        }
    

        #endregion
    }
}
