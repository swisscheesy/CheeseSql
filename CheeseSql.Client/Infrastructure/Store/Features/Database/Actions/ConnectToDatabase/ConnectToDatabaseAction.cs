using CheeseSql.Shared.Models.Authentication;

namespace CheeseSql.Client.Infrastructure.Store.Features.Database.Actions.ConnectToDatabase
{
    public class ConnectToDatabaseAction
    {
        public ConnectToDatabaseAction(ConnectionOptions options)
        {
            ConnectionOptions = options;
        }

        public ConnectionOptions ConnectionOptions { get; set; }
    }
}