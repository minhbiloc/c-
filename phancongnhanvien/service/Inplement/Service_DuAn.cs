using Microsoft.EntityFrameworkCore;
using phancongnhanvien.DataContext;
using phancongnhanvien.Entities;
using phancongnhanvien.Payload.Converter;
using phancongnhanvien.Payload.DTO;
using phancongnhanvien.Payload.Request.DuAn;
using phancongnhanvien.Payload.Response;
using phancongnhanvien.service.Interface;

namespace phancongnhanvien.service.Inplement
{
    public class Service_DuAn : IService_DuAn
    {
        private readonly AppDbContext dbContext;
        private readonly ResponseObject<DTO_DuAn> responseObject;
        private readonly Converter_DuAn converter_DuAn;
        private readonly ResponseBase responseBase;

        public Service_DuAn(AppDbContext dbContext, ResponseObject<DTO_DuAn> responseObject, Converter_DuAn converter_DuAn, ResponseBase responseBase)
        {
            this.dbContext = dbContext;
            this.responseObject = responseObject;
            this.converter_DuAn = converter_DuAn;
            this.responseBase = responseBase;
        }

        public IQueryable<DTO_DuAn> GetListDuAn(int pageSize, int pageNumber)
        {

            return dbContext.duAns.Skip((pageNumber - 1) * pageSize).Take(pageSize).Select(x => converter_DuAn.EntityToDTO(x));
        }

      
        public ResponseObject<DTO_DuAn> SuaDuAn(Request_SuaDuAn request)
        {
            var duAn = dbContext.duAns.FirstOrDefault(x => x.Id == request.Id);
            if (duAn == null)
            {
                return responseObject.ResponseObjectError(StatusCodes.Status404NotFound, "Dự án không tồn tại !", null);

            }

            duAn.TenDuAn = request.TenDuAn;
            duAn.GhiChu = request.GhiChu;
            duAn.MoTa = request.MoTa;
            dbContext.duAns.Update(duAn);
            dbContext.SaveChanges();

            return responseObject.ResponseObjectSuccess("Sửa thành công !", converter_DuAn.EntityToDTO(duAn));
        }

        public ResponseObject<DTO_DuAn> ThemDuAn(Request_ThemDuAn request)
        {
            var duan = new DuAn();
            duan.TenDuAn = request.TenDuAn;
            duan.MoTa = request.MoTa;
            duan.GhiChu = request.GhiChu;
            duan.MoTa = request.MoTa;
            dbContext.duAns.Add(duan);
            dbContext.SaveChanges();
            return responseObject.ResponseObjectSuccess("Thêm thành công", converter_DuAn.EntityToDTO(duan));
        }

        public ResponseBase XoaDuAn(int DuAnId)
        {
            var duAn = dbContext.duAns.FirstOrDefault(x => x.Id == DuAnId);
            if (duAn == null)
            {
                return responseBase.ResponseBaseError(StatusCodes.Status404NotFound, "Dự án không tồn tại !");

            }
            dbContext.duAns.Remove(duAn);
            dbContext.SaveChanges();
            return responseBase.ResponseBaseSuccess("Xóa thành công !");
        }
    }



}

   