namespace BattleshipLogic
{
    public class TargetGrid
    {
        private readonly int rows = 10;
        private readonly int columns = 10;

        public Player Player { get; } = player;
        public Peg[,] Pegs { get; }

        public TargetGrid(Player player)
        {
            Player = player;
            Pegs = GenerateInitialPegs();
        }

        public Peg this[int row, int column]
        {
            get
            {
                this[new Position(row, column)];
            }
            set
            {
                this[new Position(row, column)] = value;
            }
        }

        public Peg this[Position pos]
        {
            get
            {
                if (Position.IsValidPosition(pos))
                {
                    return Pegs[pos.row, pos.column];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("position", "invalid position");
                }
            }
            set
            {
                if (Position.IsValidPosition(pos) && Pegs[pos.Row, pos.Column] == Peg.None)
                {
                    Pegs[pos.Row, pos.Column] = value;
                }
                else if (Position.IsValidPosition(pos))
                {
                    throw new argumentOutOfRangeException("position", "invalid position");
                }
                else
                {
                    throw new argument
                }
            }
        }

        private Peg[,] GenerateInitialPegs()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Pegs[r, c] = Peg.None;
                }
            }
        }
        
    }
}
