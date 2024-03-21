namespace BattleshipLogic
{
    public class Tile(Position pos)
    {
        private static readonly string[] rowStrings = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J"];
        public Position Position { get; } = pos;
        public Peg Peg { get; private set; } = Peg.None;

        public void Hit()
        {
            Peg = Peg.Hit;
        }
        public void Miss()
        {
            Peg = Peg.Miss;
        }

        public bool HasPeg()
        {
            return Peg != Peg.None;
        }

        public bool IsHit()
        {
            return Peg == Peg.Hit;
        }

        public override string ToString()
        {
            return $"(r: {Position.Row}, c: {Position.Column}, {Peg.PegString()}";
        }

        public static string TileCoordinate(Tile tile)
        {
            return rowStrings[tile.Position.Row] + (tile.Position.Column + 1);
        }

    }
}
