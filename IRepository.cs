using System.Collections.Generic;

namespace RepositoryAndUnitOfWork

{

    public interface IRepository<T> where T : class 
    {
        IList<T> Getall();
        T FindByID(int id);
        void Add(T item);
        void Remove(T item);

    }

}