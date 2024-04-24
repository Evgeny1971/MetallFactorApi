using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


[ApiController]
public class EmailController : ControllerBase
{
    private readonly IEmailService _emailService;

    public EmailController(IEmailService emailService)
    {
        _emailService = emailService;
    }

    [HttpPost("send")]
    [Route("api/email-send")]
    public async Task<IActionResult> SendEmailAsync([FromBody] EmailRequestDTO request)
    {
        try
        {
            await _emailService.SendEmailAsync(request);
            return Ok("Email sent successfully.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Failed to send email: {ex.Message}");
        }
    }

    [HttpGet]
    [Route("get")]
    public IActionResult Get()
    {
        return Ok("Hello, World!");
    }
}
