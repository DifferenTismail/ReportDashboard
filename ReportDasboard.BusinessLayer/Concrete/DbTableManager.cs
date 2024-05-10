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
    public class DbTableManager : IDbTableService
    {
        private readonly IDbTableDal _dbTableDal;

        public DbTableManager(IDbTableDal dbTableDal)
        {
            _dbTableDal = dbTableDal;
        }

        public void TAdd(DbTable entity)
        {
            _dbTableDal.Add(entity);
        }

        public void TDelete(DbTable entity)
        {
            _dbTableDal.Delete(entity);
        }

        public DbTable TGetByID(int id)
        {
            return _dbTableDal.GetByID(id);
        }

        public List<DbTable> TGetListAll()
        {
            return _dbTableDal.GetListAll();
        }

        public void TUpdate(DbTable entity)
        {
            _dbTableDal.Update(entity);
        }
    }
}
