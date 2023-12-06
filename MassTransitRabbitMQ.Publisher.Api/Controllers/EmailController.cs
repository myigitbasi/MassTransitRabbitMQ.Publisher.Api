using MassTranRabbitMQ.Contracts;
using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MassTransitRabbitMQ.Publisher.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IPublishEndpoint _endPoint;

        public EmailController(IPublishEndpoint endPoint)
        {
            _endPoint = endPoint;
        }

        [HttpPost]
        public async Task<IActionResult> Send([FromBody] EMailModel model)
        {
            await _endPoint.Publish(model);
            return Ok();
        }
    }
}
