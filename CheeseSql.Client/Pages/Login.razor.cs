using System.Threading.Tasks;
using CheeseSql.Client.Infrastructure.Managers;
using CheeseSql.Client.Infrastructure.Store.State;
using CheeseSql.Client.Services;
using CheeseSql.Shared.Models.Database.Authentication;
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
        [Inject] private DatabaseManager DatabaseManager { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        private bool _isConnected { get; set; }

        protected override async Task<Task> OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        private void Connect()
        {
            DatabaseManager.ConnectionOptions = _connectionOptions;
            Facade.ConnectToDatabase(_connectionOptions.Database);
        }

        private void NavigateToDatabaseDashboard()
        {
            NavigationManager.NavigateTo("/database/dashboard");
        }
    }
}