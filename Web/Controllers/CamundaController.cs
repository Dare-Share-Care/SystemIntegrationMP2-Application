using Microsoft.AspNetCore.Mvc;
using Web.Models.Dtos;
using RabbitMQ.Producers;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class CamundaController : ControllerBase
{
    private readonly CamundaTaskProducer _taskProducer;
    private readonly CamundaExternalTaskProducer _externalTaskProducer;
    
public CamundaController(CamundaTaskProducer taskProducer, CamundaExternalTaskProducer externalTaskProducer)
{
    _taskProducer = taskProducer;
    _externalTaskProducer = externalTaskProducer;
}

    [HttpPost]
    [Route("task/complete")]
    public IActionResult CompleteTask([FromBody] CompleteCamundaTaskDto dto)
    {
        _taskProducer.SendMessage(dto);
        return Ok(new { id = dto.Id });
    }
    
    [HttpPost]
    [Route("external-task/complete")]
    public IActionResult CompleteExternalTask([FromBody] CompleteCamundaTaskDto dto)
    {
        _taskProducer.SendMessage(dto);
        return Ok(new { id = dto.Id });
    }
}