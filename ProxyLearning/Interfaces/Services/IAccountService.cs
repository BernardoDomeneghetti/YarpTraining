using System;
using ProxyLearning.Models.Domain;
using ProxyLearning.Models.DTOs;

namespace ProxyLearning.Interfaces.Services;

public interface IAccountService
{
    Task<Account> GetByIdAsync(Guid id);
    Task<Guid> CreateAsync(AccountCreationRequest accountCreationRequest);
}
