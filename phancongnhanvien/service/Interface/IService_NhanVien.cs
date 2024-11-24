using phancongnhanvien.Payload.DTO;
using phancongnhanvien.Payload.Request.NhanVien;
using phancongnhanvien.Payload.Response;

namespace phancongnhanvien.service.Interface
{
    public interface IService_NhanVien
    {
        ResponseObject<DTO_NhanVien> ThemNhanVien(Request_ThemNhanVien request);

        ResponseObject<DTO_NhanVien> SuaNhanVien(Request_SuaNhanVien request);

        ResponseBase XoaNhanVien(int NhanVienId);

        IQueryable<DTO_NhanVien> GetListNhanVien(int pageSize, int pageNumber);
    }
}
