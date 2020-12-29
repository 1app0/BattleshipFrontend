using System.Text.Json.Serialization;

namespace BattleShipFrontEnd.Data.Helpers {
    public class Coordinate {
        [JsonPropertyName("x")]
        public int X { get; set; }
        [JsonPropertyName("y")]
        public int Y { get; set; }
        [JsonPropertyName("wasHit")]
        public bool WasHit { get; set; }
        [JsonPropertyName("botWin")]
        public bool BotWin { get; set; }
        [JsonPropertyName("playerWin")]
        public bool PlayerWin { get; set; }
    }
}