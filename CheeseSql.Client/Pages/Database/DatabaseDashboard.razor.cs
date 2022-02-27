using System.Threading.Tasks;
using CheeseSql.Client.Infrastructure.Managers;
using Microsoft.AspNetCore.Components;

namespace CheeseSql.Client.Pages.Database
{
    public partial class DatabaseDashboard
    {
        [Inject] private DatabaseManager DatabaseManager { get; set; }

        private int _tableCount { get; set; }

        protected override async Task<Task> OnInitializedAsync()
        {
            var test = await DatabaseManager.QueryDatabase(QueryManager.QueryTotalTableCount());
            //Console.WriteLine("On Initialized Dashboard: {0}", test.ReturnValues[0]);
            return base.OnInitializedAsync();
        }
    }
}