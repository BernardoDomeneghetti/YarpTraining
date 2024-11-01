using System;
using ProxyLearning.Interfaces.Repositories;
using ProxyLearning.Interfaces.Services;
using ProxyLearning.Models.Domain;

namespace ProxyLearning.Services;

public class AccountService : IAccountService
{
    private readonly IAccountRepository _accountRepository;
    public Task<Account> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
