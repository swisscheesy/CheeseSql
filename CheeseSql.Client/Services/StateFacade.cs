using CheeseSql.Client.Infrastructure.Store.Features.Database.Actions.ConnectToDatabase;
using CheeseSql.Shared.Models.Authentication;
using Fluxor;
using Microsoft.Extensions.Logging;

namespace CheeseSql.Client.Services
{
    public class StateFacade
    {
        private readonly IDispatcher _dispatcher;
        private readonly ILogger<StateFacade> _logger;

        public StateFacade(ILogger<StateFacade> logger, IDispatcher dispatcher)
        {
            _logger = logger;
            _dispatcher = dispatcher;
        }

        public void ConnectToDatabase(ConnectionOptions options)
        {
            _logger.LogInformation("Action: Attempting to connect to Postgres Database");
            _dispatcher.Dispatch(new ConnectToDatabaseAction(options));
        }
    }
}