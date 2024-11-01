using System;
using System.Security.Cryptography.X509Certificates;

namespace ProxyLearning.Interfaces.Repositories;

public interface ICertificateRepository
{
    Task<X509Certificate2> GetAsync(Guid key);
    Task<X509Certificate2> Save(Guid key, X509Certificate2 certificate);
}
