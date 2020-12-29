using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BattleShipFrontEnd.Data.Helpers {
    public class ApiShootGameTileResults {
        [JsonPropertyName("coordinates")] 
        public List<Coordinate> Coordinates { get; set; }
        [JsonPropertyName("hit")]
        public bool WasHit { get; set; }
    }
}