using System;
using ProxyLearning.Models.Domain;

namespace ProxyLearning.Interfaces.Repositories;

public interface IAccountRepository
{
    Task<Account> GetByIdAsync(Guid id);

    Task CreateAsync(Account account);
}
