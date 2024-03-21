namespace BattleshipLogic
{
    public class OceanGrid(IEnumerable<Ship> ships) : Grid
    {
        public readonly IEnumerable<Ship> Ships = ships;

        public bool HasShip(Position pos)
        {
            foreach (Ship ship in Ships)
            {
                if (ship.OccupiesTile(pos))
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Ship ship in Ships)
            {
                result += ship + "\n";
            }
            return result;
        }
    }
}
