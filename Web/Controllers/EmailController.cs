using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Producers;
using Web.Models.Dtos.Email;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class EmailController : ControllerBase
{
    private readonly EmailProducer _emailProducer;

    public EmailController(EmailProducer emailProducer)
    {
        _emailProducer = emailProducer;
    }
    
    [HttpPost]
    [Route("send")]
    public IActionResult SendEmail([FromBody] EmailDto emaildto)
    {
        _emailProducer.SendMessage(emaildto);
        return Ok(new { emaildto.EmailAddress });
    }
}