using CheeseSql.Client.Infrastructure.Store.State;
using Fluxor;

namespace CheeseSql.Client.Infrastructure.Store.Features.Database
{
    public class DatabaseFeature : Feature<DatabaseState>
    {
        public override string GetName()
        {
            return "Database";
        }

        protected override DatabaseState GetInitialState()
        {
            return new(false, null, null, null);
        }
    }
}