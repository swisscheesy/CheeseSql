namespace CheeseSql.Client.Infrastructure.Store.Features.Shared
{
    /// <summary>
    ///     Base action for when an action fails or otherwise does not complete correctly
    /// </summary>
    public abstract class FailureAction
    {
        protected FailureAction(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public string ErrorMessage { get; }
    }
}