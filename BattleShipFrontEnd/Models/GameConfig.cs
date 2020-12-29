using System.Text.Json.Serialization;

namespace BattleShipFrontEnd.Models {
    public class GameConfig {
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [JsonPropertyName("botGameTilesConfig")]
        public int[] BotConfig { get; set; }
        [JsonPropertyName("playerGameTilesConfig")]
        public int[] PlayerConfig { get; set; }
        [JsonPropertyName("botShipsLeft")]
        public int BotShipsLeft { get; set; }
        [JsonPropertyName("playerShipsLeft")]
        public int PlayerShipsLeft { get; set; }
    }
}