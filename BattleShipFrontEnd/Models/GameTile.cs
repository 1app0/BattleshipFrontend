namespace BattleShipFrontEnd.Models {
    public class GameTile {
        public int X { get; set; }
        public int Y { get; set; }
        public bool EnemyBoard { get; set; }
        public bool ColorBlue { get; set; }
        public bool ColorRed { get; set; }
        public bool ColorGrey { get; set; }
    }
}