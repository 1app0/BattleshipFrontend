using System.Text.Json.Serialization;

namespace BattleShipFrontEnd.Data.Helpers {
    public class ApiPlayerShipPlacement {
        [JsonPropertyName("shipType")]
        public int ShipType { get; set; }
        [JsonPropertyName("x")]
        public int X { get; set; }
        [JsonPropertyName("y")]
        public int Y { get; set; }
        [JsonPropertyName("isVertical")]
        public bool IsVertical { get; set; }
    }
}