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
    public class WriteQueryManager : IWriteQueryService
    {
        private readonly IWriteQueryDal _writeQueryDal;

        public WriteQueryManager(IWriteQueryDal writeQueryDal)
        {
            _writeQueryDal = writeQueryDal;
        }

        public void TAdd(WriteQuery entity)
        {
            _writeQueryDal.Add(entity);
        }

        public void TDelete(WriteQuery entity)
        {
            _writeQueryDal.Delete(entity);
        }

        public WriteQuery TGetByID(int id)
        {
            return _writeQueryDal.GetByID(id);
        }

        public List<WriteQuery> TGetListAll()
        {
            return _writeQueryDal.GetListAll();
        }

        public void TUpdate(WriteQuery entity)
        {
            _writeQueryDal.Update(entity);
        }
    }
}
