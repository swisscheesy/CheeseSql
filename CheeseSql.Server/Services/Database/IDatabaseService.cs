using System.Threading.Tasks;
using CheeseSql.Shared.Models.Authentication;

namespace CheeseSql.Server.Services.Database
{
    public interface IDatabaseService
    {
        public Task<bool> OpenConnectionToServer(ConnectionOptions options);
    }
}