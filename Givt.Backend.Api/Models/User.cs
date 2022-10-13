namespace Models;

public class User
{
    public Guid Id { get; set; }

    public List<PaymentMethod> PaymentMethods { get; set; }
}