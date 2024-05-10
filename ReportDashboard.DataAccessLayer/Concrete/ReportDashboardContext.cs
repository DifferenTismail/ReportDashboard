using Microsoft.EntityFrameworkCore;
using ReportDashboard.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDashboard.DataAccessLayer.Concrete
{
    public class ReportDashboardContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AV376HC\\SQLEXPRESS; Initial Catalog=ReportDb; Integrated Security=True; TrustServerCertificate=True") ;
        }
        public DbSet<DbTable> DbTables{ get; set; }
        public DbSet<Report> Reports{ get; set; }
    }
}
