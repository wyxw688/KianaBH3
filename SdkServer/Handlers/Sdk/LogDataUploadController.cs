using Microsoft.AspNetCore.Mvc;

namespace KianaBH.SdkServer.Handlers.Sdk;

[ApiController]
public class LogDataUploadController : ControllerBase
{
    [HttpGet("/report")]
    public IActionResult Report()
    {
        return Ok(new { code = 0, message = "OK" });
    }

    [HttpPost("/{logType}/dataUpload")]
    public IActionResult LogDataUpload(string logType)
    {
        return Ok(new { code = 0, message = "OK" });
    }

    [HttpPost("/common/h5log/log/batch")]
    public IActionResult H5LogBatch()
    {
        return Ok(new { code = 0, message = "OK" });
    }

    [HttpGet("/_ts")]
    public IActionResult GetTs()
    {
        return Ok(new
        {
            code = 0,
            message = "app running",
            milliTs = DateTime.Now.Millisecond.ToString()
        });
    }
}