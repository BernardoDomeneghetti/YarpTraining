using System;
using ProxyLearning.Models.Domain;

namespace ProxyLearning.Models.DTOs;

public class CertificateCreationRequest
{
    public required Guid OwnerId { get; set; }
    public required string CertificateBase64 { get; set; }
}
