using CheeseSql.Client.Infrastructure.Store.Features.Shared;

namespace CheeseSql.Client.Infrastructure.Store.Features.Database.Actions.ConnectToDatabase
{
    public class ConnectToDatabaseFailureAction : FailureAction
    {
        public ConnectToDatabaseFailureAction(string errorMessage) : base(errorMessage)
        {
        }
    }
}