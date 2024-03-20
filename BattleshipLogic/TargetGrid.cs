namespace BattleshipLogic
{
    public class TargetGrid
    {
        private readonly int rows = 10;
        private readonly int columns = 10;

        public Player Player { get; }
        public Peg[,] Pegs { get; }

        public TargetGrid(Player player)
        {
            Player = player;
            Pegs = GenerateInitialPegs();
        }

        public bool IsEmpty(int row, int col)
        {
            return IsEmpty(new Position(row, col));
        }
        public bool IsEmpty(Position pos)
        {
            return this[pos] == Peg.None;
        }
        public bool SetPeg(Position pos, Peg peg)
        {
            if (Position.IsValidPosition(pos) && IsEmpty(pos))
            {
                this[pos] = peg;
                return true;
            }
            return false;
        }

        public Peg this[int row, int column]
        {
            get
            {
                return this[new Position(row, column)];
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
                    return Pegs[pos.Row, pos.Column];
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(pos), "Invalid position");
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
                    throw new ArgumentOutOfRangeException(nameof(pos), "Invalid position");
                }
            }
        }

        private Peg[,] GenerateInitialPegs()
        {
            Peg[,] result = new Peg[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    result[r, c] = Peg.None;
                }
            }
            return result;
        }
        
    }
}
