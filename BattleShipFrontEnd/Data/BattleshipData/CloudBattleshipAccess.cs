using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BattleShipFrontEnd.Data.Helpers;
using BattleShipFrontEnd.Models;

namespace BattleShipFrontEnd.Data.BattleshipData {
    public class CloudBattleshipAccess : ICloudBattleShipAccess{
        public async Task InitializeGameAsync() {
            HttpClient client = new HttpClient();
            await client.GetStringAsync("http://localhost:8080/battleShipBot/startGame");
        }

        public async Task<bool> CanPlayerPlaceShipAsync(int shipType, int x, int y, bool isVertical) {
            ApiPlayerShipPlacement shipPlacement = new ApiPlayerShipPlacement {
                ShipType = shipType,
                X = x,
                Y = y,
                IsVertical = isVertical
            };
            HttpClient client = new HttpClient();
            string shipPlacementSerialized = JsonSerializer.Serialize(shipPlacement);
            StringContent content = new StringContent(
                shipPlacementSerialized,
                Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage response = await client.PostAsync("http://localhost:8080/battleShipBot/playerPlaceShip", content);
            return JsonSerializer.Deserialize<bool>(await response.Content.ReadAsStringAsync());
        }

        public async Task<ApiShootGameTileResults> ShootTile(int x, int y) {
            Coordinate coordinate = new Coordinate {
                X = x,
                Y = y
            };
            HttpClient client = new HttpClient();
            string coordinateSerialized = JsonSerializer.Serialize(coordinate);
            StringContent content = new StringContent(
                coordinateSerialized,
                Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage response = await client.PostAsync("http://localhost:8080/battleShipBot/shootGameTile", content);
            return JsonSerializer.Deserialize<ApiShootGameTileResults>(await response.Content.ReadAsStringAsync());
        }

        public async Task<string> SaveGame(string username) {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(
                username,
                Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage response = await client.PostAsync("http://localhost:8080/battleShipBot/saveGame", content);
            return JsonSerializer.Deserialize<string>(await response.Content.ReadAsStringAsync());
        }

        public async Task<bool> CheckForSavedGame(string username) {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(
                username,
                Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage response = await client.PostAsync("http://localhost:8080/battleShipBot/checkGameSave", content);
            return JsonSerializer.Deserialize<bool>(await response.Content.ReadAsStringAsync());
        }

        public async Task DeleteSave(string username) {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(
                username,
                Encoding.UTF8,
                "application/json"
                );
            await client.PostAsync("http://localhost:8080/battleShipBot/deleteGameSave", content);
        }

        public async Task<GameConfig> LoadGame(string username) {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(
                username,
                Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage response = await client.PostAsync("http://localhost:8080/battleShipBot/loadGameConfig", content);
            return JsonSerializer.Deserialize<GameConfig>(await response.Content.ReadAsStringAsync());
        }
    }
}