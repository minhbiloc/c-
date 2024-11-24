namespace phancongnhanvien.Payload.Request.NhanVien
{
    public class Request_SuaNhanVien
    {
        public int Id { get; set; }
        public string HoTen { get; set; }

        public string SoDienThoai { get; set; }

        public string DiaChi { get; set; }

        public string Email { get; set; }

        public Double HeSoLuong { get; set; }
    }
}
