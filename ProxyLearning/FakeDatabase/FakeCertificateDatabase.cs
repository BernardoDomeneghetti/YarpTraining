using System;
using System.Security.Cryptography.X509Certificates;

namespace ProxyLearning.FakeDatabase;

public static class FakeCertificateDatabase
{
    // private static Dictionary<Guid, X509Certificate2> CertificateTable { get; } = new();

    // public static void AddCertificate(Guid id, X509Certificate2 certificate)
    // {
    //     CertificateTable.Add(id, certificate);
    // }

    // public static X509Certificate2? GetCertificate(Guid certificateId)
    // {   
    //     return CertificateTable.TryGetValue(certificateId, out var certificate) ? certificate : null;
    // }

    private static Dictionary<Guid, string> CertificateTable { get; } = new();

    public static void AddCertificate(Guid id, string fakeCertificate)
    {
        CertificateTable.Add(id, fakeCertificate);
    }

    public static string? GetCertificate(Guid certificateId)
    {   
        return CertificateTable.TryGetValue(certificateId, out var fakeCertificate) ? fakeCertificate : null;
    }

}
