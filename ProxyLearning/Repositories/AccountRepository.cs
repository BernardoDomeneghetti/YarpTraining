using System;
using ProxyLearning.FakeDatabase;
using ProxyLearning.Interfaces.Repositories;
using ProxyLearning.Models.Domain;

namespace ProxyLearning.Repositories;

public class AccountRepository : IAccountRepository
{
    public async Task<Account> GetByIdAsync(Guid id)
    {
        return FakeAccountDatabase.GetAccount(id);
    }

    public async Task CreateAsync(Account account)
    {
        FakeAccountDatabase.AddAccount(account);
    }
}
