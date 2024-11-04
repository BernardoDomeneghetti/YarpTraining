using System;
using System.Security.Cryptography.X509Certificates;
using ProxyLearning.Models.Domain;

namespace ProxyLearning.Interfaces.Services;

public interface ICertificateService
{
    // Task<X509Certificate2> GetAsync(Guid key);
    Task<string> GetAsync(Guid key);
    Task SaveAsync(Guid ownerId, string certificateBase64);
}
