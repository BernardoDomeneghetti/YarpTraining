using System;

namespace ProxyLearning.Models.Domain;

public class Account
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    
}
