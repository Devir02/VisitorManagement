using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VisitorManagement.Models.DAL
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private VisitorDataContext _dataContext;
        private IDbSet<T> DbEntity;
        public GenericRepository()
        { 
            _dataContext = new VisitorDataContext();
            DbEntity=_dataContext.Set<T>();
        }
        public IEnumerable<T> GetModel()
        {
            return DbEntity.ToList();
        }

        public void InsertModel(T model)
        {
            DbEntity.Add(model);
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}