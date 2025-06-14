using KianaBH.Data.Models.Sdk;
using Microsoft.AspNetCore.Mvc;

namespace KianaBH.SdkServer.Handlers.Sdk;

[ApiController]
public class AbTestController : ControllerBase
{
    [HttpPost("/data_abtest_api/config/experiment/list")]
    public IActionResult GetExperimentList()
    {
        return Ok(new ResponseBase
        {
            Data = new[]
            {
                new
                {
                    code = 1000,
                    type = 2,
                    config_id = "169",
                    period_id = "6524_721",
                    version = 2,
                    configs = new
                    {
                        hoyopass_enable = false
                    },
                    sceneWhiteList = false,
                    experimentWhiteList = false,
                }
            }
        });
    }
}