using System;
using ProxyLearning.Models.Domain;

namespace ProxyLearning.FakeDatabase;

public static class FakeAccountDatabase
{
    private static Dictionary<Guid, Account> AccountTable { get; } = new();

    public static void AddAccount(Account account)
    {
        AccountTable.Add(account.Id, account);
    }

    public static Account? GetAccount(Guid accountId)
    {   
        return AccountTable.TryGetValue(accountId, out var account) ? account : null;
    }
}
