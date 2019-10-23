using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RepositoryAndUnitOfWork

{
    public class EntityRepositoryAdapter<T> : IRepository<T>  where T : class
    {
        protected readonly DbSet<T> DbSet;
        public EntityRepositoryAdapter(DbSet<T> dbSet)
        {
            if(dbSet == null) throw new ArgumentNullException("dbSet");
            DbSet = dbSet;
        }
        public void Add(T item)
        {
            DbSet.Add(item);
        }

        public T FindByID(int id)
        {
            return DbSet.Find(id);
        }

        public IList<T> Getall()
        {
            return DbSet.ToList();


        }

        public void Remove(T item)
        {
            DbSet.Remove(item);
        }
    }

}