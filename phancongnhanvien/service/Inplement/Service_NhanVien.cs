using phancongnhanvien.DataContext;
using phancongnhanvien.Entities;
using phancongnhanvien.Payload.Converter;
using phancongnhanvien.Payload.DTO;
using phancongnhanvien.Payload.Request.NhanVien;
using phancongnhanvien.Payload.Response;
using phancongnhanvien.service.Interface;

namespace phancongnhanvien.service.Inplement
{
    public class Service_NhanVien : IService_NhanVien
    {

        private readonly AppDbContext dbContext;
        private readonly ResponseObject<DTO_NhanVien> responseObject;
        private readonly Converter_NhanVien converter_NhanVien;
        private readonly ResponseBase responseBase;

        public Service_NhanVien(AppDbContext dbContext, ResponseObject<DTO_NhanVien> responseObject, Converter_NhanVien converter_NhanVien, ResponseBase responseBase)
        {
            this.dbContext = dbContext;
            this.responseObject = responseObject;
            this.converter_NhanVien = converter_NhanVien;
            this.responseBase = responseBase;
        }

        public IQueryable<DTO_NhanVien> GetListNhanVien(int pageSize, int pageNumber)
        {
            return dbContext.nhanviens.Skip((pageNumber - 1) * pageSize).Take(pageSize).Select(x => converter_NhanVien.EntityToDTO(x));
        }

        public ResponseObject<DTO_NhanVien> SuaNhanVien(Request_SuaNhanVien request)
        {
            var nhanvien = dbContext.nhanviens.FirstOrDefault(x => x.Id == request.Id);
            if (nhanvien == null)
            {
                return responseObject.ResponseObjectError(StatusCodes.Status404NotFound, "Nhân Viên không tồn tại !", null);

            }

            
            nhanvien.DiaChi = request.DiaChi;
            nhanvien.SoDienThoai = request.SoDienThoai;
            nhanvien.HoTen = request.HoTen;
            nhanvien.HeSoLuong = request.HeSoLuong;
            nhanvien.Email = request.Email;
            dbContext.nhanviens.Update(nhanvien);
            dbContext.SaveChanges();
            return responseObject.ResponseObjectSuccess("sửa thành công ", converter_NhanVien.EntityToDTO(nhanvien));
        }

        public ResponseObject<DTO_NhanVien> ThemNhanVien(Request_ThemNhanVien request)
        {
           var nhanvien = new Nhanvien();
            nhanvien.DiaChi = request.DiaChi;
            nhanvien.SoDienThoai = request.SoDienThoai;
            nhanvien.HoTen=request.HoTen;
            nhanvien.HeSoLuong=request.HeSoLuong;
            nhanvien.Email=request.Email;
            dbContext.nhanviens.Add(nhanvien);
            dbContext.SaveChanges();
             return responseObject.ResponseObjectSuccess("thêm thành công ", converter_NhanVien.EntityToDTO(nhanvien));
        }


        public ResponseBase XoaNhanVien(int NhanVienId)
        {
            var nhanvien = dbContext.nhanviens.FirstOrDefault(x => x.Id == NhanVienId);
            if (nhanvien == null)
            {
                return responseBase.ResponseBaseError(StatusCodes.Status404NotFound, "Nhân viên không tồn tại !");

            }
            dbContext.nhanviens.Remove(nhanvien);
            dbContext.SaveChanges();
            return responseBase.ResponseBaseSuccess("Xóa thành công !");
        }

       
    }

    

}
