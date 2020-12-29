using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace BattleShipFrontEnd.Models {
    public class User {
     
        [Required]
        [NotNull]
        [JsonPropertyName("Username")]
        public string Username { get; set; }
        
        
        [Required]
        [NotNull]
        [JsonPropertyName("Password")]
        public string Password { get; set; }
       
        [JsonPropertyName("AccessType")]
        public string AccessType { get; set; }
    }
}