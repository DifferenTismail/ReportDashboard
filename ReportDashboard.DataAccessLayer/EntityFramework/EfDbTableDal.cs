using ReportDashboard.DataAccessLayer.Abstract;
using ReportDashboard.DataAccessLayer.Concrete;
using ReportDashboard.DataAccessLayer.Repositories;
using ReportDashboard.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDashboard.DataAccessLayer.EntityFramework
{
    public class EfDbTableDal : GenericRepository<DbTable>, IDbTableDal
    {
        public EfDbTableDal(ReportDashboardContext context) : base(context)
        {
        }
    }
}
