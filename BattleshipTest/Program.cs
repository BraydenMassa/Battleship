using BattleshipLogic;

namespace Tests
{
    public class Program
    {
        public static void Main()
        {
            Tile carrierPos = new(new Position(0, 0));
            Tile battleshipPos = new(new Position(4, 4));
            Tile cruiserPos = new(new Position(6, 6));
            Tile destroyerPos = new(new Position(3, 9));
            Tile submarinePos = new(new Position(8, 3));

            IEnumerable<Ship> ships = [new Carrier(carrierPos, Direction.East),
            new Battleship(battleshipPos, Direction.East),
            new Cruiser(cruiserPos, Direction.South),
            new Destroyer(destroyerPos, Direction.South),
            new Submarine(submarinePos, Direction.East)];
            Player p1 = new(PlayerID.One, ships);
            OceanGrid og = p1.OceanGrid;
            Console.WriteLine(p1);
            Console.WriteLine(og.HasShip(new Position(8, 5)));
        }
    }
}
