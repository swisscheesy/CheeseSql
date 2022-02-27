namespace CheeseSql.Client.Infrastructure.Store.State
{
    /// <summary>
    ///     State for a Postgres Database instance that will be interacted with
    /// </summary>
    public class DatabaseState : RootState
    {
        public DatabaseState(bool isLoading, string? currentErrorMessage, bool? isConnected,
            string? connectionDatabase)
            : base(isLoading, currentErrorMessage)
        {
            IsConnected = isConnected;
            ConnectionDatabase = connectionDatabase;
        }

        public bool? IsConnected { get; }
        public string? ConnectionDatabase { get; }
    }
}