using System.Collections.Immutable;

namespace PicpayChal.App.Entities;

public record Wallet(string Name, string Cpf, string Email, int Type, decimal Balance)
{
    public long Id { get; private set; } = 0L;

    public IImmutableList<int> Transactions { get; set; } = [];

    private Wallet()
        : this(string.Empty, string.Empty, string.Empty, default, default);
}


public static class WalletExtensions
{
    extension(Wallet)
    {
        public static Wallet Create(string name, string cpf, string email, int type, decimal balance = 0.0m) =>
            new(name, cpf, email, type, balance);
    }


    extension(Wallet wallet)
    {
        public Wallet Debit(decimal amount) =>
            wallet with { Balance = wallet.Balance - amount };

        public Wallet Credit(decimal amount) =>
            wallet with { Balance = wallet.Balance + amount };
    }
}