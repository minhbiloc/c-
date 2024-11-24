namespace phancongnhanvien.Entities
{
    public class PhanCong : EntityBase
    {

        public int NhanVienId { get; set; }

        public int DuAnId { get; set; }

        public double SoGioLam { get; set; }

        public Nhanvien? NhanVien { get; set; }

        public DuAn? DuAn { get; set; }
    }
}
