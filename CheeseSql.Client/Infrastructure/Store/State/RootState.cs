namespace CheeseSql.Client.Infrastructure.Store.State
{
    /// <summary>
    ///     Base State to inherit from that holds properties that are valid for all component states
    /// </summary>
    public abstract class RootState
    {
        public RootState(bool isLoading, string? currentErrorMessage)
        {
            (IsLoading, CurrentErrorMessage) = (isLoading, currentErrorMessage);
        }

        public bool IsLoading { get; }
        public string? CurrentErrorMessage { get; }
        public bool HasCurrentError => !string.IsNullOrWhiteSpace(CurrentErrorMessage);
    }
}