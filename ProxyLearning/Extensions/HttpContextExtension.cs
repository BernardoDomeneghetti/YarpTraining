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

        var authorizationHeader = context.Request.Headers[HeaderNames.Authorization];
        
        ArgumentNullException.ThrowIfNull(authorizationHeader, nameof(authorizationHeader));

        var token = authorizationHeader.ToString().Split(" ")[1];
        var id = Guid.Parse(token);

        return await _accountService.GetByIdAsync(id);
    }
}
