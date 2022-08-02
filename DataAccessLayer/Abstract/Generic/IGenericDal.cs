using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract.Generic
{
    public interface IGenericDal<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        List<TEntity> GetList();
        TEntity GetById(int id);

    }
}
