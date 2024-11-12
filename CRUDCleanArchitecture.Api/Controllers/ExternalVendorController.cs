using CRUDCleanArchitecture.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDCleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalVendorController(ISender sender) : ControllerBase
    {
        [HttpGet("")]
        public async Task<IActionResult> GetCoindeskData()
        {
            var result = await sender.Send(new GetCoindeskDataQuery());

            return Ok(result);
        }
    }
}
