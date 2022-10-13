namespace Givt.TwoPointOh.Backend.Api.Requests;

public record CreateDonationRequest(
    decimal Amount,
    string MediumId,
    DateTime CreatedOnDevice
);
