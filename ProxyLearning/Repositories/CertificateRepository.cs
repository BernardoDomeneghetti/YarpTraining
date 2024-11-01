using System;
using System.Security.Cryptography.X509Certificates;
using ProxyLearning.Interfaces.Repositories;

namespace ProxyLearning.Repositories;

public class CertificateRepository : ICertificateRepository
{
    public async Task<X509Certificate2> GetAsync(Guid key)
    {
        throw new NotImplementedException();
    }

    public async Task<X509Certificate2> Save(Guid key, X509Certificate2 certificate)
    {
        throw new NotImplementedException();
    }
}
