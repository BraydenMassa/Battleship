namespace BattleshipLogic
{
    public enum PlayerID
    {
        One, Two
    }

    public static class PlayerExtensions
    {
        public static PlayerID Opponent(this PlayerID player )
        {
            return player == PlayerID.One ? PlayerID.Two : PlayerID.One;
        }
        public static string PlayerIDString(this PlayerID player )
        {
            return player == PlayerID.One ? "Player one" : "Player two";
        }
    }
}
