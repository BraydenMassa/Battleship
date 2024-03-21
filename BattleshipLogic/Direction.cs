namespace BattleshipLogic
{
    public class Direction(int rowDelta, int columnDelta)
    {
        public static readonly Direction East = new(0, 1);
        public static readonly Direction South = new(1, 0);

        public int ColumnDelta { get; } = columnDelta;
        public int RowDelta { get; } = rowDelta;

        public static Direction operator *(Direction dir, int scalar)
        {
            return new Direction(dir.RowDelta * scalar, dir.ColumnDelta * scalar);
        }

    }
}
