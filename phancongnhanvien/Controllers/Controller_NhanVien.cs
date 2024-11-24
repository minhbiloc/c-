using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using phancongnhanvien.Payload.Request.DuAn;
using phancongnhanvien.Payload.Request.NhanVien;
using phancongnhanvien.service.Inplement;
using phancongnhanvien.service.Interface;

namespace phancongnhanvien.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller_NhanVien : ControllerBase
    {
        private readonly IService_NhanVien service_NhanVien;

        public Controller_NhanVien(IService_NhanVien service_NhanVien)
        {
            this.service_NhanVien = service_NhanVien;
        }
        [HttpPost("Thêm Nhân Viên")]
        public IActionResult ThemNhanVien(Request_ThemNhanVien request)
        {
            return Ok(service_NhanVien.ThemNhanVien(request));

        }
        [HttpPut("sửa Nhân Viên")]
        public IActionResult SuaNhanVien(Request_SuaNhanVien request)
        {
            return Ok(service_NhanVien.SuaNhanVien(request));

        }
        [HttpDelete("Xóa Nhân Viên")]
        public IActionResult XoaNhanVien(int DuAnId)
        {
            return Ok(service_NhanVien.XoaNhanVien(DuAnId));
        }
        [HttpGet("Lấy danh sách Nhân Viên")]
        public IActionResult getListDuanFull(int pageSize = 10, int pageNumber = 1)
        {
            return Ok(service_NhanVien.GetListNhanVien(pageSize, pageNumber));
        }
    }
}
