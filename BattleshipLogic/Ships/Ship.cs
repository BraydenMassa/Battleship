namespace BattleshipLogic
{
    public abstract class Ship
    {
        public abstract ShipType Type { get; }
        public abstract int Length { get; }
        public IEnumerable<Tile> Tiles { get; }
        public bool IsCaptured { get; private set; }

        public Ship(Tile source, Direction dir)
        {
            Tiles = BuildInitialTiles(source, dir);
            IsCaptured = false;
        }

        public override string ToString()
        {
            string result = Type.ShipTypeString() + "\n";
            foreach (Tile tile in Tiles)
            {
                result += tile + "\n";
            }
            return result;
        }


        public void Hit(Position pos)
        {
            foreach (Tile tile in Tiles)
            {
                if (tile.Position == pos && !tile.HasPeg())
                {
                    tile.Hit();
                    CheckForCapture();
                }
            }
        }
        public bool OccupiesTile(Position pos)
        {
            foreach (Tile tile in Tiles)
            {
                if (pos == tile.Position)
                {
                    return true;
                }
            }
            return false;
        }
        private IEnumerable<Tile> BuildInitialTiles(Tile source, Direction dir)
        {
            for (int i = 0; i < Length; i++)
            {
                yield return new Tile(source.Position + (dir * i));
            }
        }
        private void CheckForCapture()
        {
            int hits = 0;
            foreach (Tile tile in Tiles)
            {
                if (tile.IsHit())
                {
                    hits++;
                }
            }
            IsCaptured = hits == Length;
        }
    }
}
