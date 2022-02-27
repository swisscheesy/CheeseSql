using System.Threading.Tasks;
using CheeseSql.Shared.Models.Database;
using CheeseSql.Shared.Models.Database.Authentication;

namespace CheeseSql.Server.Services.Database
{
    public interface IDatabaseService
    {
        public Task<ConnectionOptions> OpenConnectionToServer(ConnectionOptions options);
        public Task<QueryReturn> QueryDatabase(DatabaseQuery query);
    }
}