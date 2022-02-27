using CheeseSql.Shared.Models.Database;

namespace CheeseSql.Client.Infrastructure.Managers
{
    public static class QueryManager
    {
        public static DatabaseQuery TestConnectionQuery()
        {
            return new DatabaseQuery
            {
                QueryString = "SELECT 1",
                QueryParameters = null
            };
        }

        public static DatabaseQuery QueryTotalTableCount()
        {
            return new DatabaseQuery
            {
                QueryString =
                    "SELECT count(*) FROM pg_catalog.pg_tables WHERE schemaname != 'pg_catalog' AND schemaname != 'information_schema'",
                QueryParameters = null
            };
        }
    }
}