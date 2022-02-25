using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CheeseSql.Server.Controllers
{
    // TODO: Implement Logs
    public abstract class BaseApiController<T> : ControllerBase
    {
        private ILogger<T> _loggerInstance;
    }
}