using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Givt.TwoPointOh.Backend.Api.Requests;
public class RequestErrorResult<T> : ActionResult
{
    public HttpStatusCode StatusCode { get; set; }
    public T? Exception { get; set; }
    public string? Message { get; set; }
}