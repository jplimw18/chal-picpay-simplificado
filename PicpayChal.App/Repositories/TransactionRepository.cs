using PicpayChal.App.Data;
using PicpayChal.App.Entities;
using PicpayChal.App.Repositories.Interfaces;

namespace PicpayChal.App.Repositories;

public sealed class TransactionRepository : BaseRepository<Transaction>, ITransactionRepository
{
    public TransactionRepository(AppDbContext context)
        : base(context) { }
}
