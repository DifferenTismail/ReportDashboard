using Microsoft.EntityFrameworkCore;
using ReportDashboard.DataAccessLayer.Abstract;
using ReportDashboard.DataAccessLayer.Concrete;
using ReportDashboard.DataAccessLayer.Repositories;
using ReportDashboard.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ReportDashboard.DataAccessLayer.EntityFramework
{
    public class EfReportDal : GenericRepository<Report>, IReportDal
    {
        private readonly ReportDashboardContext context;

        public EfReportDal(ReportDashboardContext context) : base(context)
        {
        }
        public List<Report> GetReportsWithDbTable()
        {
            var values = context.Reports
                                .Include(r => r.DbTable)
                                .ToList();
            return values;
        }
        
    }
}
