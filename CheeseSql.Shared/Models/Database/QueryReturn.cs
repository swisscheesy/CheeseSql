using System.Collections.Generic;

namespace CheeseSql.Shared.Models.Database
{
    public class QueryReturn
    {
        public QueryReturn()
        {
            ReturnValues = new List<string>();
        }

        public IList<string> ReturnValues { get; set; }
    }
}