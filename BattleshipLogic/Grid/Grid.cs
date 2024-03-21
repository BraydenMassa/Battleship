namespace BattleshipLogic
{
    public abstract class Grid
    {
        private readonly int rows = 10;
        private readonly int columns = 10;
        public IEnumerable<Tile> Tiles { get; }

        public Grid()
        {
            Tiles = GenerateInitialTiles();
        }

        private IEnumerable<Tile> GenerateInitialTiles()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    yield return new Tile(new Position(r, c));
                }
            }
        }
    }
}
