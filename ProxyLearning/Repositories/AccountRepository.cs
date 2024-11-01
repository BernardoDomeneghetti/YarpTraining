using System;
using ProxyLearning.Interfaces.Repositories;
using ProxyLearning.Models.Domain;

namespace ProxyLearning.Repositories;

public class AccountRepository : IAccountRepository
{
    public Task<Account> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
