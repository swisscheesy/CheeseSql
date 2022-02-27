using System.ComponentModel.DataAnnotations;

namespace CheeseSql.Shared.Models.DTOs.Database
{
    public record DatabaseConnectionDto
    {
        [Required] public string Host { get; set; }
        [Required] public string Port { get; set; }
        [Required] public string Username { get; set; }
        [Required] public string Database { get; set; }
    }
}