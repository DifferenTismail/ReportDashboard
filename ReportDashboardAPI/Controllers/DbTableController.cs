
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ReportDashboard.BusinessLayer.Abstarct;
using ReportDashboard.DtoLayer.DbTableDto;
using ReportDashboard.EntityLayer.Entities;
using Npgsql;
using Oracle.ManagedDataAccess.Client;
using Microsoft.Data.Sqlite;
using MySql.Data;
using MySql.Data.MySqlClient;
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
            if (createDbTableDto == null)
            {
                return BadRequest("Invalid data.");
            }

            DbTable dbTable = new DbTable()
            {
                DBMS_Name = createDbTableDto.DBMS_Name,
                DbTable_ServerName = createDbTableDto.DbTable_ServerName,
                DbTable_Database = createDbTableDto.DbTable_Database,
                DbTable_UserName = createDbTableDto.DbTable_UserName,
                DbTable_Password = createDbTableDto.DbTable_Password
            };

            try
            {
                _dbTableService.TAdd(dbTable);
                return Ok("Veri Tabanı Başarılı Bir Şekilde Kayıt Edildi");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
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
                DbTable_Database = updateDbTableDto.DbTable_Database,
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
