using System;
using System.Net.Http;
using System.Threading.Tasks;
using CheeseSql.Client.Services;
using Fluxor;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;

namespace CheeseSql.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(
                sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});

            // Add Fluxor for state management
            builder.Services.AddFluxor(o => o
                .ScanAssemblies(typeof(Program).Assembly)
                .UseReduxDevTools());

            // Add State Facade Service
            builder.Services.AddScoped<StateFacade>();

            // Add Mudblazor Component Library
            builder.Services.AddMudServices();

            await builder.Build().RunAsync();
            Console.WriteLine("Running Client");
        }
    }
}