using System;
using ProxyLearning.Models.Domain;

namespace ProxyLearning.Interfaces.Services;

public interface IAccountService
{
    Task<Account> GetByIdAsync(Guid id);
}
