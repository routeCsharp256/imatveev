using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OzonEdu.MerchApi.Services.Interfaces;

namespace OzonEdu.MerchApi.Controllers
{
    [ApiController]
    [Route("v1/api/")]
    [Produces("application/json")]
    public class MerchController : ControllerBase
    {
        private readonly IMerchService _merchService;

        public MerchController(IMerchService merchService)
        {
            _merchService = merchService;
        }

        /// <summary>
        /// Запросить мерч.
        /// </summary>
        [HttpGet("/giveMerchByEmployeeId{employeeId:long}")]
        public async Task<ActionResult> Give(long employeeId, CancellationToken token)
        {
            await _merchService.Give(employeeId, token);
            return Ok();
        }
        
        /// <summary>
        /// Запросить информацию о выдаче мерча.
        /// </summary>
        [HttpGet("/checkMerchByEmployeeId{employeeId:long}")]
        public async Task<ActionResult<bool>> Check(long employeeId, CancellationToken token)
        {
            var merchStatus = await _merchService.Check(employeeId, token);
            return Ok(merchStatus);
        }
    }
}