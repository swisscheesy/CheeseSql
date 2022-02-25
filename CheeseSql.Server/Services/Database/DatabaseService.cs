using System;
using System.Data;
using System.Threading.Tasks;
using CheeseSql.Shared.Models.Authentication;
using Npgsql;

namespace CheeseSql.Server.Services.Database
{
    public class DatabaseService : IDatabaseService
    {
        private NpgsqlConnection _connection;

        public async Task<bool> OpenConnectionToServer(ConnectionOptions options)
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
                    return true;
                }

                Console.WriteLine("Not Connected");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting");
                return false;
            }
        }
    }
}