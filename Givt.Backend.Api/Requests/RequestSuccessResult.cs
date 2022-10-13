using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Givt.TwoPointOh.Backend.Api.Requests;
public class RequestSuccessResult<T> : ActionResult
{
    public HttpStatusCode StatusCode { get; set; }
    public T? Body { get; set; }
}
