using ProxyLearning.Interfaces.Repositories;
using ProxyLearning.Interfaces.Services;
using ProxyLearning.Models.Domain;
using ProxyLearning.Models.DTOs;

namespace ProxyLearning.Services;

public class AccountService : IAccountService
{
    private readonly IAccountRepository _accountRepository;

    public AccountService(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<Account> GetByIdAsync(Guid id)
    {
        return await _accountRepository.GetByIdAsync(id);
    }

    public async Task<Guid> CreateAsync(AccountCreationRequest accountCreationRequest)
    {
        var account = new Account
            {
                Id = Guid.NewGuid(),
                Name = accountCreationRequest.Name
            };

        await _accountRepository.CreateAsync(account);
        
        return account.Id;
    }
}
