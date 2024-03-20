namespace BattleshipLogic
{
    public class Carrier : Ship
    {
        private readonly Position[][] tiles = new Position[][]
        {

        };
        public override Position[][] Tiles { get; }
        public override ShipType Type => ShipType.Carrier;
        public override bool IsCaptured => false;

        public Carrier() 
        {
            
        }


    }
}
