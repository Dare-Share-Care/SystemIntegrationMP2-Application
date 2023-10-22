using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Implementations;
using Web.Models.Dtos;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class CamundaController : ControllerBase
{
    private readonly IMessageProducer _messageProducer;
    
public CamundaController(IMessageProducer messageProducer)
    {
        _messageProducer = messageProducer;
    }

    [HttpPost]
    [Route("task/complete")]
    public IActionResult Post([FromBody] CompleteCamundaTaskDto dto)
    {
        _messageProducer.SendMessage(dto);
        return Ok(new { id = dto.Id });
    }
}