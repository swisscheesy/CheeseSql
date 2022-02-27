using CheeseSql.Client.Infrastructure.Store.Features.Database.Actions.ConnectToDatabase;
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

        /// <summary>
        ///     Dispatches a ConnectToDatabase action
        /// </summary>
        /// <param name="connectionDatabase"></param>
        public void ConnectToDatabase(string connectionDatabase)
        {
            _logger.LogInformation("Action: Attempting to connect to Postgres Database");
            _dispatcher.Dispatch(new ConnectToDatabaseAction(connectionDatabase));
        }

        public void IsConnectedQuery(string query)
        {
            _logger.LogInformation("Action: Querying the database to check connection");
        }
    }
}