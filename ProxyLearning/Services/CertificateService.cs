using System;
using System.Security.Cryptography.X509Certificates;
using ProxyLearning.Interfaces.Repositories;
using ProxyLearning.Interfaces.Services;
using ProxyLearning.Models.Domain;

namespace ProxyLearning.Services;

public class CertificateService : ICertificateService
{
    private readonly ICertificateRepository _certificateRepository;

    public CertificateService(ICertificateRepository certificateRepository)
    {
        _certificateRepository = certificateRepository;
    }

    // public async Task<X509Certificate2> GetAsync(Guid key)
    // {
    //     return await _certificateRepository.GetAsync(key);
    // }

    public async Task<string> GetAsync(Guid key)
    {
        return await _certificateRepository.GetAsync(key);
    }

    public async Task SaveAsync(Guid ownerId, string certificateBase64)
    {
        //var certificate = new X509Certificate2(Convert.FromBase64String(certificateBase64));
        var fakeCertificate = certificateBase64;
        await _certificateRepository.SaveAsync(ownerId, fakeCertificate);
    }
}
