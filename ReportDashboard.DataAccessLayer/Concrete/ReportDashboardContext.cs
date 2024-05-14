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
        public ReportDashboardContext(DbContextOptions<ReportDashboardContext> options) : base(options) { }
        public DbSet<DbTable> DbTables{ get; set; }
        public DbSet<Report> Reports{ get; set; }
        public DbSet<WriteQuery> WriteQueries { get; set; }
    }
}
