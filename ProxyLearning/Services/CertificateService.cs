using System;
using System.Security.Cryptography.X509Certificates;
using ProxyLearning.Interfaces.Repositories;
using ProxyLearning.Interfaces.Services;

namespace ProxyLearning.Services;

public class CertificateService : ICertificateService
{
    private readonly ICertificateRepository _certificateRepository;

    public CertificateService(ICertificateRepository certificateRepository)
    {
        _certificateRepository = certificateRepository;
    }

    public async Task<X509Certificate2> GetAsync(Guid key)
    {
        throw new NotImplementedException();
    }

    public Task<X509Certificate2> Save(Guid key, X509Certificate2 certificate)
    {
        throw new NotImplementedException();
    }
}
