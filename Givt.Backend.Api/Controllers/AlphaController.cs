using Givt.TwoPointOh.Backend.Api.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Givt.TwoPointOh.Backend.Api.Controllers;

[ApiController]
[Route("api[controller]")]
public class AlphaController : ControllerBase
{
    [HttpPost, Route("donations")]
    [ProducesResponseType(201, Type = typeof(RequestSuccessResult<string>))]
    public IActionResult PostDonation([FromBody] CreateDonationRequest request)
    {
        return new RequestSuccessResult<string>();
    }

    [HttpGet, Route("campaigns")]
    [ProducesResponseType(200, Type = typeof(RequestSuccessResult<GetCampaignResponse>))]
    public ActionResult GetCampaigns([FromQuery] GetCampaignRequest request)
    {
        return new RequestSuccessResult<GetCampaignResponse>();
    }
}
