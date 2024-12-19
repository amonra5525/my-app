using Microsoft.AspNetCore.Mvc;

namespace Example.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class JiraController : ControllerBase
{
    [HttpGet("check")]
    public Task<IActionResult> GetJiraInfo()
    {
        return Task.FromResult<IActionResult>(Ok("Gems Jira now available"));
    }
}