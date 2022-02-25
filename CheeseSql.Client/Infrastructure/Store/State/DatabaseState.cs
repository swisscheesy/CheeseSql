using CheeseSql.Shared.Models.Authentication;

namespace CheeseSql.Client.Infrastructure.Store.State
{
    /// <summary>
    ///     State for a Postgres Database instance that will be interacted with
    /// </summary>
    public class DatabaseState : RootState
    {
        public DatabaseState(bool isLoading, string? currentErrorMessage, bool? isConnected,
            ConnectionOptions? connectionOptions)
            : base(isLoading, currentErrorMessage)
        {
            IsConnected = isConnected;
            ConnectionOptions = connectionOptions;
        }

        public bool? IsConnected { get; }
        public ConnectionOptions? ConnectionOptions { get; }
    }
}