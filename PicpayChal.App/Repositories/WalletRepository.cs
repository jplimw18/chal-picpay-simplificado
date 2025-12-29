using PicpayChal.App.Data;
using PicpayChal.App.Entities;

namespace PicpayChal.App.Repositories;

public sealed class WalletRepository : BaseRepository<Wallet>
{
    public WalletRepository(AppDbContext context)
        : base(context) { }
}
