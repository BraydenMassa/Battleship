namespace BattleshipLogic
{
    public class Carrier(Tile source, Direction dir) : Ship(source, dir)
    {
        public override ShipType Type => ShipType.Carrier;

        public override int Length => 5;
    }
}
