namespace Models;

public class Donation
{
    public Guid Id { get; }

    public decimal Amount { get; set; }
    public string Currency { get; set; }

    public User User { get; set; }
    public Guid UserId { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public Guid PaymentMethodId { get; set; }
    public Campaign Campaign { get; set; }
    public Guid CampaignId { get; set; }

    public DateTime CreatedOnDevice { get; set; }
    public DateTime? EnteredOnServer { get; set; }
    public DateTime? LastUpdated { get; set; }
}