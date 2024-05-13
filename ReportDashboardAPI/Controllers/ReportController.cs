using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReportDashboard.BusinessLayer.Abstarct;
using ReportDashboard.DataAccessLayer.Concrete;
using ReportDashboard.DtoLayer.ReportDto;
using ReportDashboard.EntityLayer.Entities;

namespace ReportDashboardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;
        private readonly IMapper _mapper;
        private readonly ReportDashboardContext context;

        public ReportController(IReportService reportService, IMapper mapper, ReportDashboardContext context)
        {
            _reportService = reportService;
            _mapper = mapper;
            this.context = context;
        }
        [HttpGet("ReportList")]
        public IActionResult ReportList()
        {
            var values = _mapper.Map<List<ResultReportDto>>(_reportService.TGetListAll());
            return Ok(values);
        }
        [HttpGet("ReportListWithDbTable_UserName")]
        public IActionResult ReportListWithDbTable_UserName()
        {
            var values = context.Reports.Include(x => x.DbTable).Select(y => new ResultReportWithDbTable
            {
                ReportID = y.ReportID,
                ReportName = y.ReportName,
                DbTable_UserName = y.DbTable.DbTable_UserName
            });
            return Ok(values.ToList());
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
