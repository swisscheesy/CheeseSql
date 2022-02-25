using System.Threading.Tasks;
using CheeseSql.Server.Services.Database;
using CheeseSql.Shared.Models.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace CheeseSql.Server.Controllers.v1
{
    [Route("api/database")]
    [ApiController]
    public class DatabaseController : BaseApiController<DatabaseController>
    {
        private readonly IDatabaseService _databaseService;

        public DatabaseController(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        [HttpPost("connect")]
        public async Task<IActionResult> ConnectToDatabase(ConnectionOptions options)
        {
            var success = await _databaseService.OpenConnectionToServer(options);
            if (success)
                return Ok();
            return NotFound();
        }
    }
}