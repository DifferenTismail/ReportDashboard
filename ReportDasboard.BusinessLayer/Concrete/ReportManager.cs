using ReportDashboard.BusinessLayer.Abstarct;
using ReportDashboard.DataAccessLayer.Abstract;
using ReportDashboard.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDashboard.BusinessLayer.Concrete
{
    public class ReportManager : IReportService
    {
        private readonly IReportDal _reportDal;

        public ReportManager(IReportDal reportDal)
        {
            _reportDal = reportDal;
        }

        public void TAdd(Report entity)
        {
            _reportDal.Add(entity);
        }

        public void TDelete(Report entity)
        {
            _reportDal.Delete(entity);
        }

        public Report TGetByID(int id)
        {
            return _reportDal.GetByID(id);
        }

        public List<Report> TGetListAll()
        {
            return _reportDal.GetListAll();
        }

        public List<Report> TGetReportsWithDbTable()
        {
            return _reportDal.GetReportsWithDbTable();
        }

        public void TUpdate(Report entity)
        {
            _reportDal.Update(entity);
        }
    }
}
