using System;
using System.Security.Cryptography.X509Certificates;

namespace ProxyLearning.Communication.Http;

public class CustomClientCertificateHandler : DelegatingHandler
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CustomClientCertificateHandler(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var context = _httpContextAccessor.HttpContext;

        ArgumentNullException.ThrowIfNull(context, nameof(context));

        if (context.Items.TryGetValue(CommunicationConsts.ContextCertificateItemIndexer, out var certObj) && certObj is X509Certificate2 certificado)
        {
            var handler = InnerHandler as HttpClientHandler;
            handler?.ClientCertificates.Add(certificado);
            
            return await base.SendAsync(request, cancellationToken);
        }

        throw new ArgumentException("The object found in the context is not a X509Certificate2");
    }
}