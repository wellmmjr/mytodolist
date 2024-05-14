using mytodolist.Model;
using mytodolist.Model.Base;
using System.Collections.Generic;

namespace mytodolist.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);

        T FindById(long id);

        List<T> FindAll();

        T Update(T item);

        void Delete(long id);
    }
}
