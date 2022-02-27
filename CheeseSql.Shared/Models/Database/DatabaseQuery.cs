using System.Collections.Generic;

namespace CheeseSql.Shared.Models.Database
{
    public class DatabaseQuery
    {
        public string QueryString { get; set; }
        public List<string> QueryParameters { get; set; }
    }
}