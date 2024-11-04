using System;
using System.Security.Cryptography.X509Certificates;

namespace ProxyLearning.Interfaces.Repositories;

public interface ICertificateRepository
{
    // Task<X509Certificate2> GetAsync(Guid key);
    //Task SaveAsync(Guid key, X509Certificate2 certificate);
    Task<string> GetAsync(Guid key);
    Task SaveAsync(Guid key, string fakeCertificate);
}
