using phancongnhanvien.Entities;
using phancongnhanvien.Payload.DTO;

namespace phancongnhanvien.Payload.Converter
{
    public class Converter_DuAn
    {
        public DTO_DuAn EntityToDTO(DuAn duAn)
        {
            return new DTO_DuAn
            {
                Id = duAn.Id,
                TenDuAn = duAn.TenDuAn,
                MoTa = duAn.MoTa,
                GhiChu = duAn.GhiChu,
            };
        }
    }
}