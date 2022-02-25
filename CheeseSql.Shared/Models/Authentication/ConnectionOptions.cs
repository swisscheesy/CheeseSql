using System.ComponentModel.DataAnnotations;

namespace CheeseSql.Shared.Models.Authentication
{
    public class ConnectionOptions
    {
        [Required] public string Host { get; set; }

        [Required] public string Port { get; set; }

        [Required] public string Username { get; set; }
        [Required] public string Password { get; set; }

        [Required] public string Database { get; set; }
    }
}