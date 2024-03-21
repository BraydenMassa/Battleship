namespace BattleshipLogic
{
    public class Player(PlayerID playerID, IEnumerable<Ship> ships)
    {
        public PlayerID PlayerID { get; } = playerID;
        public TargetGrid TargetGrid { get; } = new TargetGrid();
        public OceanGrid OceanGrid { get; } = new OceanGrid(ships);

        public override string ToString()
        {
            return PlayerID.PlayerIDString() + "\n" + OceanGrid;
        }

    }
}
