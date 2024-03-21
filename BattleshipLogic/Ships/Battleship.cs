namespace BattleshipLogic
{
    public class Battleship(Tile source, Direction dir) : Ship(source, dir)
    {
        public override ShipType Type => ShipType.Battleship;

        public override int Length => 4;
    }
}
