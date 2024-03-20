namespace BattleshipLogic
{
    public class Position(int row, int column)
    {
        public int Row { get; } = row;
        public int Column { get; } = column;

        public static bool IsValidPosition(Position position)
        {
            return position.Column >= 0 && 
                   position.Column < 10 && 
                   position.Row >= 0 && 
                   position.Row < 10;
        }
    }
}
