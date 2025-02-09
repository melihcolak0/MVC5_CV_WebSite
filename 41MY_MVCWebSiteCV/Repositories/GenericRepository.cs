using _41MY_MVCWebSiteCV.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace _41MY_MVCWebSiteCV.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        Entities dataBase = new Entities();

        public List<T> List()
        {
            return dataBase.Set<T>().ToList();
        }

        public void TAdd(T p)
        {
            dataBase.Set<T>().Add(p);
            dataBase.SaveChanges();
        }

        public void TDelete(T p)
        {
            dataBase.Set<T>().Remove(p);
            dataBase.SaveChanges();
        }

        public T TGet(int id)
        {
            return dataBase.Set<T>().Find(id);
        }

        public void TUpdate(T p)
        {            
            dataBase.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return dataBase.Set<T>().FirstOrDefault(where);
        }
    }   
}