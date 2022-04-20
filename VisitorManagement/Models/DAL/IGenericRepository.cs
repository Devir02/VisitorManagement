using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorManagement.Models.DAL
{
    interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetModel();
        void InsertModel(T model);
        void Save();
    }
}
