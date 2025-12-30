namespace PicpayChal.App.Repositories.Interfaces;

public interface IUnitOfWork
{
    void Commit();
    Task CommitAsync();
}
