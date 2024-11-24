using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using phancongnhanvien.Payload.Request.DuAn;
using phancongnhanvien.Payload.Request.NhanVien;
using phancongnhanvien.service.Interface;

namespace phancongnhanvien.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller_DuAn : ControllerBase
    {
        private readonly IService_DuAn service_DuAn;

        public Controller_DuAn(IService_DuAn service_DuAn)
        {
            this.service_DuAn = service_DuAn;
        }

        [HttpPost("Thêm dự án")]
        public IActionResult ThemDuAn(Request_ThemDuAn request)
        {
            return Ok(service_DuAn.ThemDuAn(request));

        }
        [HttpPut("sửa dự án")]
        public IActionResult SuaDuAn(Request_SuaDuAn request)
        {
            return Ok(service_DuAn.SuaDuAn(request));

        }
        [HttpDelete("Xóa dự án")]
        public IActionResult XoaDuAn(int DuAnId)
        {
            return Ok(service_DuAn.XoaDuAn(DuAnId));
        }
        [HttpGet("Lấy danh sách dự án")]
        public IActionResult getListDuanFull(int pageSize = 10, int pageNumber = 1)
        {
            return Ok(service_DuAn.GetListDuAn(pageSize, pageNumber));
        }
    }
}
