using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CheeseSql.Client.Infrastructure.Routes;
using CheeseSql.Shared.Models.Database;
using CheeseSql.Shared.Models.Database.Authentication;
using Microsoft.Extensions.Logging;

namespace CheeseSql.Client.Infrastructure.Managers
{
    public class DatabaseManager
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger;
        private ConnectionOptions _connectionOptions;


        public DatabaseManager(ILogger<DatabaseManager> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public ConnectionOptions ConnectionOptions
        {
            get => _connectionOptions;
            set => _connectionOptions = value ?? throw new ArgumentNullException(nameof(value));
        }

        public async Task<QueryReturn> QueryDatabase(DatabaseQuery query)
        {
            if (_connectionOptions != null)
            {
                _logger.LogInformation("Querying Database...");
                var response =
                    await _httpClient.PostAsJsonAsync(DatabaseEndpoints.QueryDatabase(), query);
                var data = await response.Content.ReadFromJsonAsync<QueryReturn>();
                return data;
            }

            return null;
        }
    }
}