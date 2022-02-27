namespace CheeseSql.Client.Infrastructure.Store.Features.Database.Actions.ConnectToDatabase
{
    public class ConnectToDatabaseAction
    {
        public ConnectToDatabaseAction(string database)
        {
            ConnectedDatabase = database;
        }

        public string ConnectedDatabase { get; set; }
    }
}