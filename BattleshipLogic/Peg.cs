namespace BattleshipLogic
{
    public enum Peg
    {
        Hit, Miss, None
    }
    public static class PegExtensions
    {
        public static string PegString(this Peg p)
        {
            return p switch
            {
                Peg.Hit => "Hit",
                Peg.Miss => "Miss",
                _ => "None",
            };
        }
    }


}