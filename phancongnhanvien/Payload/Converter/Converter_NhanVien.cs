using phancongnhanvien.Entities;
using phancongnhanvien.Payload.DTO;

namespace phancongnhanvien.Payload.Converter
{
    public class Converter_NhanVien
    {
        public DTO_NhanVien EntityToDTO(Nhanvien nhanvien)
        {
            return new DTO_NhanVien
            {
                Id = nhanvien.Id,
                DiaChi = nhanvien.DiaChi,
                Email = nhanvien.Email,
                HeSoLuong = nhanvien.HeSoLuong,
                HoTen = nhanvien.HoTen,
                SoDienThoai = nhanvien.SoDienThoai,
            };
        }
    }
}