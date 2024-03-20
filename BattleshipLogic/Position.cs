namespace BattleshipLogic
{
    public class Position(int row, int column)
    {
        public int Row { get; set; } = row;
        public int Column { get; set; } = column;

        public static Position[] operator +(Position[] basePositions, Position offset)
        {
            return basePositions.Select(p => new Position(p.Row + offset.Row, p.Column + offset.Column)).ToArray();
        }

        public static Position operator *(Position basePosition, int offset) 
        { 
            return new Position(basePosition.Row * offset, basePosition.Column * offset);
        }

        public static bool IsValidPosition(Position position)
        {
            return IsValidRow(position) && IsValidColumn(position);
        }
        public static bool IsValidRow(Position position)
        {
            return position.Row >= 0 && position.Row < 10;
        }
        public static bool IsValidColumn(Position position)
        {
            return position.Column >= 0 && position.Column < 10;
        }

    }
}
