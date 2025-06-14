using KianaBH.Data.Models.Sdk;
using Microsoft.AspNetCore.Mvc;

namespace KianaBH.SdkServer.Models.Sdk;

[ApiController]
public class RiskyController : ControllerBase
{
    [HttpPost("/account/risky/api/check")]
    public IActionResult ComboGranter()
    {
        return Ok(new ResponseBase { Data = new { } });
    }
}