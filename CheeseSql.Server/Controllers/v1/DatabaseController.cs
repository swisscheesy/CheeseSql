using System;
using System.Threading.Tasks;
using CheeseSql.Server.Services.Database;
using CheeseSql.Shared.Models.Database;
using CheeseSql.Shared.Models.Database.Authentication;
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
            Console.WriteLine("[Controller] Connect endpoint hit");
            var retValue = await _databaseService.OpenConnectionToServer(options);
            if (retValue != null)
                return Ok(new {retValue.Host, retValue.Port, retValue.Username, retValue.Database});
            return NotFound();
        }

        [HttpPost("query")]
        public async Task<IActionResult> QueryDatabase(DatabaseQuery query)
        {
            Console.WriteLine("[Controller] Query endpoint hit");
            if (query != null)
            {
                Console.WriteLine("[Controller] Found query");
                var retValue = await _databaseService.QueryDatabase(query);

                return Ok(retValue);
            }

            Console.WriteLine("[Controller] No Query Found");
            return BadRequest();
        }
    }
}