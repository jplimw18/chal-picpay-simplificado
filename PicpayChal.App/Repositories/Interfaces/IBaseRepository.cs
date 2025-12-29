using System.Collections.Immutable;
using PicpayChal.App.Entities;

namespace PicpayChal.App.Repositories.Interfaces;

public interface IBaseRepository<T> where T : BaseEntity
{
    T Create(T entity);
    T Update(T entity);
    void Delete(T entity);

    Task<T> GetById(long Id);
    Task<List<T>> GetAll();
}