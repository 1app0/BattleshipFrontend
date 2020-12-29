using System.Threading.Tasks;
using BattleShipFrontEnd.Models;

namespace BattleShipFrontEnd.Data.BattleshipData {
    public class GameTileService : IGameTileService{
        private int rows = 10;
        private int columns = 10;
        private bool isEnemy = false;
        
        public async Task<GameTile[]> GetGameTilesAsync() {
            GameTile[] gameTiles = new GameTile[10 * 10];
            for (int yy = 0; yy < rows; yy++) {
                for (int xx = 0; xx < columns; xx++) {
                    GameTile gameTile = new GameTile{X = xx, Y = yy, EnemyBoard = isEnemy};
                    gameTiles[getIndex(xx, yy)] = gameTile;
                }
            }

            isEnemy = !isEnemy;
            return gameTiles;
        }

        private int getIndex(int x, int y) {
            return y * columns + x;
        }
    }
}