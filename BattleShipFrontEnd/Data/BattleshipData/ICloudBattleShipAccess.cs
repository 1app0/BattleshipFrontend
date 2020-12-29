using System.Threading.Tasks;
using BattleShipFrontEnd.Data.Helpers;
using BattleShipFrontEnd.Models;

namespace BattleShipFrontEnd.Data.BattleshipData {
    public interface ICloudBattleShipAccess {
        Task InitializeGameAsync();
        Task<bool> CanPlayerPlaceShipAsync(int shipType, int x, int y, bool isVertical);
        Task<ApiShootGameTileResults> ShootTile(int x, int y);
        Task<string> SaveGame(string username);
        Task<bool> CheckForSavedGame(string username);
        Task DeleteSave(string username);
        Task<GameConfig> LoadGame(string username);
    }
}