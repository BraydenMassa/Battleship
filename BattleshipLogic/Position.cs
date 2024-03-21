
namespace BattleshipLogic
{
    public class Position(int row, int column)
    {
        public int Row { get; set; } = row;
        public int Column { get; set; } = column;
        public Peg Peg { get; private set; } = Peg.None;

        public static Position operator +(Position pos, Direction dir)
        {
            return new Position(pos.Row + dir.RowDelta, pos.Column + dir.ColumnDelta);
        }

        

        public static bool IsValid(Position pos)
        {
            return IsValidRow(pos) && IsValidColumn(pos);
        }
        
        private static bool IsValidRow(Position pos)
        {
            return pos.Row >= 0 && pos.Row < 10;
        }
        private static bool IsValidColumn(Position pos)
        {
            return pos.Column >= 0 && pos.Column < 10;
        }

        public override bool Equals(object? obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Column == position.Column &&
                   Peg == position.Peg;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column, Peg);
        }
        public static bool operator ==(Position? left, Position? right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }
        public static bool operator !=(Position? left, Position? right)
        {
            return !(left == right);
        }
    }
}
