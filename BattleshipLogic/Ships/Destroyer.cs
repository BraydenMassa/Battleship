namespace BattleshipLogic
{
    public class Destroyer(Tile source, Direction dir) : Ship(source, dir)
    {
        public override ShipType Type => ShipType.Destroyer;

        public override int Length => 2;
    }
}
