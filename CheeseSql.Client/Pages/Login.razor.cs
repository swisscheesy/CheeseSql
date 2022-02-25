using CheeseSql.Client.Infrastructure.Store.State;
using CheeseSql.Client.Services;
using CheeseSql.Shared.Models.Authentication;
using Fluxor;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CheeseSql.Client.Pages
{
    public partial class Login
    {
        private readonly ConnectionOptions _connectionOptions = new();
        private MudForm _form;

        [Inject] private IState<DatabaseState> DatabaseState { get; set; }
        [Inject] private StateFacade Facade { get; set; }

        private void Connect()
        {
            Facade.ConnectToDatabase(_connectionOptions);
        }
    }
}