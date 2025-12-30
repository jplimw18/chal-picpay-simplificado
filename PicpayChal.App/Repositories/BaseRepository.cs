using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using PicpayChal.App.Data;
using PicpayChal.App.Entities;
using PicpayChal.App.Repositories.Interfaces;

namespace PicpayChal.App.Repositories;

public abstract class BaseRepository<T>(AppDbContext context) 
    : IBaseRepository<T> where T : BaseEntity
{
    protected readonly AppDbContext Context = context;

    public T Create(T entity) =>
        Context.Add(entity).Entity;

    public void Delete(T entity) =>
        Context.Remove(entity);

    public List<T> GetAll() =>
        [.. Context.Set<T>()];

    public T GetById(long Id) =>
        Context.Set<T>().FirstOrDefault(x => x.Id == Id)!;

    public T Update(T entity) =>
        Context.Update(entity).Entity;
}
