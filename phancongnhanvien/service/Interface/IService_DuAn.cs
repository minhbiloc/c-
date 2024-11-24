using phancongnhanvien.Payload.DTO;
using phancongnhanvien.Payload.Request.DuAn;
using phancongnhanvien.Payload.Request.NhanVien;
using phancongnhanvien.Payload.Response;

namespace phancongnhanvien.service.Interface
{
    public interface IService_DuAn
    {
        ResponseObject<DTO_DuAn> ThemDuAn(Request_ThemDuAn request);

        ResponseObject<DTO_DuAn> SuaDuAn(Request_SuaDuAn request);

        ResponseBase XoaDuAn(int DuAnId);

        IQueryable<DTO_DuAn> GetListDuAn(int pageSize, int pageNumber);

        
    }
}
