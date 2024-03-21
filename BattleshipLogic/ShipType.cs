namespace BattleshipLogic
{
    public enum ShipType
    {
        Carrier,
        Battleship,
        Cruiser,
        Submarine,
        Destroyer
    }

    public static class ShipTypeExtensions
    {
        public static string ShipTypeString(this ShipType shipType)
        {
            return shipType switch
            {
                ShipType.Carrier => "Carrier",
                ShipType.Battleship => "Battleship",
                ShipType.Cruiser => "Cruiser",
                ShipType.Submarine => "Submarine",
                ShipType.Destroyer => "Destroyer",
                _ => "",
            };
        }
    }

}
