using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReportDashboard.BusinessLayer.Abstarct;
using ReportDashboard.DtoLayer.WriteQueryDto;
using ReportDashboard.EntityLayer.Entities;

namespace ReportDashboardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WriteQueryController : ControllerBase
    {
        private readonly IWriteQueryService _writeQueryService;

        public WriteQueryController(IWriteQueryService writeQueryService)
        {
            _writeQueryService = writeQueryService;
        }
        [HttpGet("WriteQueryList")]
        public IActionResult WriteQueryList() 
        {
            var values = _writeQueryService.TGetListAll();
            return Ok(values);
        }
        [HttpPost("CreateWriteQuery")]
        public IActionResult CreateWriteQuery(CreateWriteQueryDto createWriteQueryDto)
        {
            WriteQuery writeQuery = new WriteQuery()
            {
                Query = createWriteQueryDto.Query
            };
            _writeQueryService.TAdd(writeQuery);
            return Ok("Query Başarılı Bir Şekilde Kayıt Edildi");
        }
        [HttpDelete("DeleteWriteQuery")]
        public IActionResult DeleteWriteQuery(int id)
        {
            var value = _writeQueryService.TGetByID(id);
            _writeQueryService.TDelete(value);
            return Ok("Query Başarılı Bir Şekilde Silindi");
        }
        [HttpPut("UpdateWriteQuery")]
        public IActionResult UpdateWriteQuery(UpdateWriteQueryDto updateWriteQueryDto)
        {
            WriteQuery writeQuery = new WriteQuery()
            { 
                WriteQueryID = updateWriteQueryDto.WriteQueryID,
                Query = updateWriteQueryDto.Query
            };
            _writeQueryService.TUpdate(writeQuery);
            return Ok("Query Başarılı Bir Şekilde Güncellendi");
        }
        [HttpGet("GetWriteQuery")]
        public IActionResult GetWriteQuery(int id)
        {
            var value = _writeQueryService.TGetByID(id);
            return Ok(value);
        }
    }
}
