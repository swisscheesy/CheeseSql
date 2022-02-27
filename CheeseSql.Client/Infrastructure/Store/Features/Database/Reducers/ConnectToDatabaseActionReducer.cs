using CheeseSql.Client.Infrastructure.Store.Features.Database.Actions.ConnectToDatabase;
using CheeseSql.Client.Infrastructure.Store.State;
using Fluxor;

namespace CheeseSql.Client.Infrastructure.Store.Features.Database.Reducers
{
    public static class ConnectToDatabaseActionReducer
    {
        [ReducerMethod]
        public static DatabaseState ReduceConnectToDatabaseAction(DatabaseState state, ConnectToDatabaseAction _)
        {
            return new DatabaseState(true, null, false, null);
        }

        [ReducerMethod]
        public static DatabaseState ReduceConnectToDatabaseSuccessAction(DatabaseState state,
            ConnectToDatabaseSuccessAction action)
        {
            return new DatabaseState(false, null, action.IsConnected, action.ConnectedDatabase);
        }

        [ReducerMethod]
        public static DatabaseState ReduceConnectToDatabaseFailureAction(DatabaseState state,
            ConnectToDatabaseFailureAction action)
        {
            return new DatabaseState(false, action.ErrorMessage, false, null);
        }
    }
}