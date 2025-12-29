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

    public Task<List<T>> GetAll() =>
        Context.Set<T>().ToListAsync();

    public Task<T> GetById(long Id) =>
        Context.Set<T>().FirstOrDefaultAsync(x => x.Id == Id)!;

    public T Update(T entity) =>
        Context.Update(entity).Entity;
}
