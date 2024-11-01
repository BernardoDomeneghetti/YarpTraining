using ProxyLearning.Extensions;
using ProxyLearning.Interfaces.Repositories;

namespace ProxyLearning.Communication.Middlaware;

public class CustomMiddlewareProxy: IMiddleware
{
    private ICertificateRepository _certificateRepository { get; set; }

    public CustomMiddlewareProxy(ICertificateRepository certificateRepository)
    {
        _certificateRepository = certificateRepository;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var loggedAccount = await context.GetLoggedAccountAsync();

        var certificate = await _certificateRepository.GetAsync(loggedAccount.Id);

        context.Items.Add(CommunicationConsts.ContextCertificateItemIndexer, certificate);   
    }
}