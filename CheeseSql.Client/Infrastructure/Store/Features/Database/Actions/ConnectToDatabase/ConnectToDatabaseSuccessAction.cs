namespace CheeseSql.Client.Infrastructure.Store.Features.Database.Actions.ConnectToDatabase
{
    public class ConnectToDatabaseSuccessAction
    {
        public ConnectToDatabaseSuccessAction(bool isConnected, string connectedDatabase)
        {
            IsConnected = isConnected;
            ConnectedDatabase = connectedDatabase;
        }

        public bool IsConnected { get; }

        public string ConnectedDatabase { get; }
    }
}