using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReportDashboard.BusinessLayer.Abstarct;
using ReportDashboard.DtoLayer.ReportDto;
using ReportDashboard.EntityLayer.Entities;

namespace ReportDashboardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }
        [HttpGet("ReportList")]
        public IActionResult ReportList()
        {
            var values = _reportService.TGetListAll();
            return Ok(values);
        }
        [HttpPost("CreateReport")]
        public IActionResult CreateReport(CreateReportDto createReportDto) 
        {
            Report report = new Report()
            {
                ReportName = createReportDto.ReportName
            };
            _reportService.TAdd(report);
            return Ok("Rapor Başarılı Bir Şekilde Kayıt Edildi");
        }
        [HttpDelete("ReportDelete")]
        public IActionResult DeleteReport(int id)
        {
            var value = _reportService.TGetByID(id);
            _reportService.TDelete(value);
            return Ok("Rapor Alanı Başarılı Bir Şekilde Silindi");
        }

        [HttpPut("UpdateReport")]
        public IActionResult UpdateReport(UpdateReportDto updateReportDto)
        {
            Report report = new Report()
            {
                ReportID = updateReportDto.ReportID,
                ReportName = updateReportDto.ReportName
            };
            _reportService.TUpdate(report);
            return Ok("Rapor Alanı Başarılı Bir Şekilde Güncellendi");
        }
        [HttpGet("GetReport")]
        public IActionResult GetReport(int id) 
        {
            var value = _reportService.TGetByID(id);
            return Ok(value);
        }
    }
}
