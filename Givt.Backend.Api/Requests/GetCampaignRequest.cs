namespace Givt.TwoPointOh.Backend.Api.Requests;
public record GetCampaignRequest(
    string? Code,
    Guid? Campaign,
    Guid? Recipient,
    Guid? Location,
    Guid? Collect
);
