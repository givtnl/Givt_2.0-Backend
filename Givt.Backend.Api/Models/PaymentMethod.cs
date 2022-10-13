namespace Models;

public class PaymentMethod
{
    public Guid Id { get; set; }
    public string? Fingerprint { get; }
    public string? Signature { get; set; }
}