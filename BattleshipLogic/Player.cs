namespace BattleshipLogic
{
    public enum Player
    {
        One, Two
    }

    public static class PlayerExtensions
    {
        public static Player Opponent(this Player player )
        {
            return player == Player.One ? Player.Two : Player.One;
        }
    }
}
