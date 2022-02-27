using System;
using System.Data;
using System.Threading.Tasks;
using CheeseSql.Shared.Models.Database;
using CheeseSql.Shared.Models.Database.Authentication;
using Npgsql;

namespace CheeseSql.Server.Services.Database
{
    public class DatabaseService : IDatabaseService
    {
        private NpgsqlConnection _connection;

        public async Task<ConnectionOptions> OpenConnectionToServer(ConnectionOptions options)
        {
            try
            {
                var connectionString =
                    $"Host={options.Host};Port={options.Port};Username={options.Username};Password={options.Password};Database={options.Database};Timeout=5";
                Console.WriteLine(connectionString);
                _connection = new NpgsqlConnection(connectionString);
                await _connection.OpenAsync();
                if (_connection.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connected!");
                    return options;
                }

                Console.WriteLine("Not Connected");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting");
                return null;
            }
        }

        public async Task<QueryReturn> QueryDatabase(DatabaseQuery query)
        {
            var queryReturn = new QueryReturn();
            // First check to ensure a connection has existed
            if (_connection != null)
                // Check to ensure connection is active
                if (_connection.State == ConnectionState.Open)
                {
                    // Create command
                    var queryCommand = new NpgsqlCommand();
                    queryCommand.Connection = _connection;
                    // If query has no parameters, set the command to the query string
                    if (query.QueryParameters == null)
                        queryCommand.CommandText = query.QueryString;
                    else
                        Console.WriteLine("Parameters found");

                    await using var queryReader = await queryCommand.ExecuteReaderAsync();

                    while (await queryReader.ReadAsync())
                    {
                        var value = queryReader.GetString(0);
                        queryReturn.ReturnValues.Add(value);
                        //Console.WriteLine("Query return: {0}", queryReader.GetString(0));
                    }
                }

            return queryReturn;
        }
    }
}