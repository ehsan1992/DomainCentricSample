using AuctionManagement.Application.Contracts;
using Framework.Application;
using Microsoft.AspNetCore.Mvc;

namespace AuctionManagement.RestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuctionsController : ControllerBase
    {
        private readonly ICommandBus _commandBus;

        public AuctionsController(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }
        [HttpGet]
        public string Get()
        {
            return "Test";
        }
        [HttpPost]
        public IActionResult Post(OpenAuctionCommand command)
        {
            _commandBus.Dispatch(command);
            return Ok();
        }
        [HttpPost("{id}/{Bids}")]
        public IActionResult Post(long id)
        {
            return Ok();
        }
    }
}
