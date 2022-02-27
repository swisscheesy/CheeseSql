namespace CheeseSql.Client.Infrastructure.Routes
{
    public class DatabaseEndpoints
    {
        //public static string Connect = "api/v1/connect";


        public static string Connect()
        {
            return "api/database/connect";
        }

        public static string QueryDatabase()
        {
            return "/api/database/query";
        }
    }
}