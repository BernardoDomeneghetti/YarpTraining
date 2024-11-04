using System;
using System.Security.Cryptography.X509Certificates;
using ProxyLearning.FakeDatabase;
using ProxyLearning.Interfaces.Repositories;

namespace ProxyLearning.Repositories;

public class CertificateRepository : ICertificateRepository
{
    // public async Task<X509Certificate2> GetAsync(Guid key)
    // {
    //     return FakeCertificateDatabase.GetCertificate(key);
    // }

    // public async Task SaveAsync(Guid key, X509Certificate2 certificate)
    // {
    //     FakeCertificateDatabase.AddCertificate(key, certificate);
    // }

    public async Task<string> GetAsync(Guid key)
    {
        return FakeCertificateDatabase.GetCertificate(key);
    }
    public async Task SaveAsync(Guid key, string fakeCertificate)
    {
        FakeCertificateDatabase.AddCertificate(key, fakeCertificate);
    }
}
