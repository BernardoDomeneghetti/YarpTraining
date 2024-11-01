using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using ProxyLearning.Communication.Http;
using ProxyLearning.Communication.Middlaware;
using ProxyLearning.Interfaces.Repositories;
using ProxyLearning.Interfaces.Services;
using ProxyLearning.Repositories;
using ProxyLearning.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        ConfigureServices(builder.Services, builder.Configuration);

        var app = builder.Build();

        app.MapReverseProxy(proxyPipeline => proxyPipeline.UseMiddleware<CustomMiddlewareProxy>());
        
        app.Run();
    }

    private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {

        #region Services
        services.AddSingleton<IAccountService, AccountService>();
        services.AddSingleton<ICertificateService, CertificateService>();
        #endregion

        
        #region Repositories
        services.AddSingleton<IAccountRepository, AccountRepository>();
        services.AddSingleton<ICertificateRepository, CertificateRepository>();
        #endregion

        #region SetUps
        
        #endregion

        #region HttpProxy

        services.AddHttpContextAccessor();

        services.AddSingleton<DelegatingHandler, CustomClientCertificateHandler>();

        services
            .AddReverseProxy()
            .LoadFromConfig(configuration.GetSection("ReverseProxy"));

        #endregion
    }
}