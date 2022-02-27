using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CheeseSql.Client.Infrastructure.Managers;
using CheeseSql.Client.Infrastructure.Routes;
using CheeseSql.Client.Infrastructure.Store.Features.Database.Actions.ConnectToDatabase;
using Fluxor;
using Microsoft.Extensions.Logging;

namespace CheeseSql.Client.Infrastructure.Store.Features.Database.Effects
{
    public class ConnectToDatabaseEffect : Effect<ConnectToDatabaseAction>
    {
        private readonly DatabaseManager _databaseManager;
        private readonly HttpClient _httpClient;
        private readonly ILogger<ConnectToDatabaseEffect> _logger;

        public ConnectToDatabaseEffect(ILogger<ConnectToDatabaseEffect> logger, HttpClient httpClient,
            DatabaseManager databaseManager)
        {
            _logger = logger;
            _httpClient = httpClient;
            _databaseManager = databaseManager;
        }

        public override async Task HandleAsync(ConnectToDatabaseAction action, IDispatcher dispatcher)
        {
            try
            {
                _logger.LogInformation("Connecting to Postgres Database...");
                var response =
                    await _httpClient.PostAsJsonAsync(DatabaseEndpoints.Connect(), _databaseManager.ConnectionOptions);
                Console.WriteLine("Connection information: {0}", _databaseManager.ConnectionOptions);
                _logger.LogInformation("Successfully Connected to Postgres Database");
                dispatcher.Dispatch(new ConnectToDatabaseSuccessAction(true, action.ConnectedDatabase));
            }
            catch (Exception e)
            {
                _logger.LogError("Error connecting to database: {Message}", e.Message);
                dispatcher.Dispatch(new ConnectToDatabaseFailureAction(e.Message));
            }
        }
    }
}