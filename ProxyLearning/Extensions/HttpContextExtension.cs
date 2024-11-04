using System;
using System.Security.Principal;
using Microsoft.Net.Http.Headers;
using ProxyLearning.Interfaces.Services;
using ProxyLearning.Models.Domain;

namespace ProxyLearning.Extensions;

public static class HttpContextExtension
{
    private static IAccountService _accountService { get; set; }

    public static void SetSingletonAccountService(IAccountService accountService)
    {
        if (_accountService != null)
        {
            throw new Exception("AccountService is already set");
        }

        _accountService = accountService;
    }
    public static async Task<Account> GetLoggedAccountAsync(this HttpContext context)
    {
        if (_accountService == null)
        {
            throw new Exception("AccountService is not set");
        }
        var loggedAccountIdString = context.Request.Headers["AccountId"].ToString();
        var guidId = Guid.Parse(loggedAccountIdString);

        return await _accountService.GetByIdAsync(guidId);
    }
}
