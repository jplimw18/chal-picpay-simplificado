using PicpayChal.App.Data;
using PicpayChal.App.Repositories.Interfaces;

namespace PicpayChal.App.Repositories;

public sealed class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    private readonly AppDbContext _context = context;

    public void Commit() =>
        _context.SaveChanges();

    public Task CommitAsync() =>
        _context.SaveChangesAsync();
}
