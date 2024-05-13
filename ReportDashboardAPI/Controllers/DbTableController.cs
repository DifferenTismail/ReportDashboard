
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReportDashboard.BusinessLayer.Abstarct;
using ReportDashboard.DtoLayer.DbTableDto;
using ReportDashboard.EntityLayer.Entities;

namespace ReportDashboardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbTableController : ControllerBase
    {
        private readonly IDbTableService _dbTableService;

        public DbTableController(IDbTableService dbTableService)
        {
            _dbTableService = dbTableService;
        }
        [HttpGet("DbTableList")]
        public IActionResult DbTableList()
        {
            var values = _dbTableService.TGetListAll();
            return Ok(values);
        }
        [HttpPost("CreateDbTable")]
        public IActionResult CreateDbTable(CreateDbTableDto createDbTableDto)
        {
            DbTable dbTable = new DbTable()
            {
                DbTable_ServerName = createDbTableDto.DbTable_ServerName,
                DbTable_UserName = createDbTableDto.DbTable_UserName,
                DbTable_Password = createDbTableDto.DbTable_Password
            };
            _dbTableService.TAdd(dbTable);
            return Ok("Veri Tabanı Başarılı Bir Şekilde Kayıt Edildi");
        }
        [HttpDelete("DbTableDelete")]
        public IActionResult DeleteDbTable(int id)
        {
            var value = _dbTableService.TGetByID(id);
            _dbTableService.TDelete(value);
            return Ok("Veri Tabanı Başarılı Bir Şekilde Silindi");
        }
        [HttpPut("DbTableUpdate")]
        public IActionResult DbTableUpdate(UpdateDbTableDto updateDbTableDto)
        {
            DbTable dbTable = new DbTable()
            {
                DbTableID = updateDbTableDto.DbTableID,
                DbTable_ServerName = updateDbTableDto.DbTable_ServerName,
                DbTable_UserName = updateDbTableDto.DbTable_UserName,
                DbTable_Password = updateDbTableDto.DbTable_Password
            };
            _dbTableService.TUpdate(dbTable);
            return Ok("Veri Tabanı Bilgileri Başarılı Bir Şekilde Güncellendi");
        }
        [HttpGet("GetDbTable")]
        public IActionResult GetDbTable(int id)
        {
            var value = _dbTableService.TGetByID(id);
            return Ok(value);
        }
    }
}
