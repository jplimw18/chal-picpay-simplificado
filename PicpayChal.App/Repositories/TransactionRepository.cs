using PicpayChal.App.Data;
using PicpayChal.App.Entities;

namespace PicpayChal.App.Repositories;

public sealed class TransactionRepository : BaseRepository<Transaction>
{
    public TransactionRepository(AppDbContext context)
        : base(context) { }
}
