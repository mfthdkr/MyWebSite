using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract.Generic;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.EntityFramework.Concrete.Generic
{
    public class Repository<TEntity> : IGenericDal<TEntity> where TEntity : class
    {
        public void Insert(TEntity entity)
        {
            using MyWebSiteContext myWebSiteContext = new MyWebSiteContext();
            myWebSiteContext.Add(entity);
            myWebSiteContext.SaveChanges();

        }

        public void Delete(TEntity entity)
        {
            using MyWebSiteContext myWebSiteContext = new MyWebSiteContext();
            myWebSiteContext.Remove(entity);
            myWebSiteContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            using MyWebSiteContext myWebSiteContext = new MyWebSiteContext();
            myWebSiteContext.Update(entity);
            myWebSiteContext.SaveChanges();
        }

        public List<TEntity> GetList()
        {
            using MyWebSiteContext myWebSiteContext = new MyWebSiteContext();
            return myWebSiteContext.Set<TEntity>().ToList();

        }

        public TEntity GetById(int id)
        {
            using MyWebSiteContext myWebSiteContext = new MyWebSiteContext();
            return myWebSiteContext.Set<TEntity>().Find(id);
        }
    }
}
