namespace BattleshipLogic
{
    public class Submarine(Tile source, Direction dir) : Ship(source, dir)
    {
        public override ShipType Type => ShipType.Submarine;

        public override int Length => 3;
    }
}
