namespace BattleshipLogic
{
    public class Cruiser(Tile source, Direction dir) : Ship(source, dir)
    {
        public override ShipType Type => ShipType.Cruiser;

        public override int Length => 3;
    }
}
