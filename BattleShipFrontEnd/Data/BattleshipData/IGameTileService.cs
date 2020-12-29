using System.Threading.Tasks;
using BattleShipFrontEnd.Models;

namespace BattleShipFrontEnd.Data.BattleshipData {
    public interface IGameTileService {
        public Task<GameTile[]> GetGameTilesAsync();
    }
}