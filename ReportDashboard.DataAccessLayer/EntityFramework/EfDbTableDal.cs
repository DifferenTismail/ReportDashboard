using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Oracle.ManagedDataAccess.Client;
using ReportDashboard.DataAccessLayer.Abstract;
using ReportDashboard.DataAccessLayer.Concrete;
using ReportDashboard.DataAccessLayer.Repositories;
using ReportDashboard.EntityLayer.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using MySql.Data.MySqlClient;
using Microsoft.Identity.Client;
using ReportDashboard.DtoLayer.DbTableDto;

namespace ReportDashboard.DataAccessLayer.EntityFramework
{
    public class EfDbTableDal : GenericRepository<DbTable>, IDbTableDal
    {
        private readonly ReportDashboardContext _context;

        public EfDbTableDal(ReportDashboardContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<DbTable>> DbTableListAsync()
        {
            return await _context.DbTables.ToListAsync();
        }

        public string VeriTabaniBaglantisi_SqlServer(GetDbTableDto model)
        {
            string connectionString = $"Server={model.DbTable_ServerName};Database={model.DbTable_Database};User Id={model.DbTable_UserName};Password={model.DbTable_Password};TrustServerCertificate=True";
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return "Veritabanı bağlantısı başarıyla yapıldı.";
                }
                catch (SqlException ex)
                {
                    return "Veritabanına bağlanırken bir hata oluştu: " + ex.Message;
                }
            }
        }

        public string VeriTabaniBaglantisi_PostgreSQL(GetDbTableDto model)
        {
            string connectionString = $"Host={model.DbTable_ServerName};Database={model.DbTable_Database};Username={model.DbTable_UserName};Password={model.DbTable_Password};";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return "Veritabanı bağlantısı başarıyla yapıldı.";
                }
                catch (NpgsqlException ex)
                {
                    return "Veritabanına bağlanırken bir hata oluştu: " + ex.Message;
                }
            }
        }

        public string VeriTabaniBaglantisi_Oracle(GetDbTableDto model)
        {
            string connectionString = $"User Id={model.DbTable_UserName};Password={model.DbTable_Password};Data Source={model.DbTable_ServerName}/{model.DbTable_Database}";
            using (var connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return "Veritabanı bağlantısı başarıyla yapıldı.";
                }
                catch (OracleException ex)
                {
                    return "Veritabanına bağlanırken bir hata oluştu: " + ex.Message;
                }
            }
        }

        public string VeriTabaniBaglantisi_SqlLite(GetDbTableDto model)
        {
            string connectionString = $"Data Source={model.DbTable_Database};";
            using (var connection = new SqliteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return "Veritabanı bağlantısı başarıyla yapıldı.";
                }
                catch (SqliteException ex)
                {
                    return "Veritabanına bağlanırken bir hata oluştu: " + ex.Message;
                }
            }
        }

        public string VeriTabaniBaglantisi_MySql(GetDbTableDto model)
        {
            string connectionString = $"Server={model.DbTable_ServerName};Database={model.DbTable_Database};User Id={model.DbTable_UserName};Password={model.DbTable_Password};";
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return "Veritabanı bağlantısı başarıyla yapıldı.";
                }
                catch (MySqlException ex)
                {
                    return "Veritabanına bağlanırken bir hata oluştu: " + ex.Message;
                }
            }
        }
    }
}
