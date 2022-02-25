using CheeseSql.Shared.Models.Authentication;

namespace CheeseSql.Client.Infrastructure.Store.Features.Database.Actions.ConnectToDatabase
{
    public class ConnectToDatabaseSuccessAction
    {
        public ConnectToDatabaseSuccessAction(bool isConnected, ConnectionOptions options)
        {
            IsConnected = isConnected;
            ConnectionOptions = options;
        }

        public bool IsConnected { get; }
        public ConnectionOptions ConnectionOptions { get; }
    }
}