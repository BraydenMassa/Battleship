using System.Data;

namespace BattleshipLogic
{
    public abstract class Ship
    {
        public abstract ShipType Type { get; }
        public abstract int NumHoles { get; }
        private readonly Position[][] tiles;
        private int rotationState;
        private Position offset;

        public Ship()
        {
            offset = new Position(0, 0);
            rotationState = 0;
            tiles = BuildTiles();
        }

        public Position[] CurrentPositions()
        {
            return tiles[rotationState] + offset;
        }
        public void Rotate()
        {
            rotationState = rotationState == 0 ? 1 : 0;
        }

        public void Move(Position offset)
        {
            Move(offset.Row, offset.Column);
        }

        public void Move(int rows, int columns)
        {
            offset.Row += rows;
            offset.Column += columns;
            SnapToGrid();
        }

        public void MoveRight(int spaces)
        {
            Move(0, 1 * spaces);
        }
        public void MoveLeft(int spaces)
        {
            Move(0, -1 * spaces);
        }
        public void MoveUp(int spaces)
        {
            Move(-1 * spaces, 0);
        }
        public void MoveDown(int spaces)
        {
            Move(1 * spaces, 0);
        }

        private void SnapToGrid()
        {
            if (!HasInvalidPosition())
            {
                return;
            }
            int spaces = 0;
            foreach (Position p in CurrentPositions())
            {
                if (!Position.IsValidPosition(p))
                {
                    spaces++;
                }
            }
            Position direction = GetInvalidDirection();
            Move(direction * spaces);
        }

        private Position GetInvalidDirection()
        {
            Position first = tiles[rotationState][0];
            Position last = tiles[rotationState][tiles.Length - 1];
            if (!Position.IsValidPosition(first))
            {
                return !Position.IsValidRow(first) ? 
            }
        }


        private Position GetInvalidRowDirection()
        {
            if (tiles[rotationState][tiles[1].Length].Row >= 10)
            {

            }
        }

        private bool HasInvalidPosition()
        {
            return HasInvalidRow() || HasInvalidColumn();
        }

        private bool HasInvalidRow()
        {
            foreach (Position p in CurrentPositions())
            {
                if (!Position.IsValidRow(p))
                {
                    return true;
                }
            }
            return false;
        }
        private bool HasInvalidColumn()
        {
            foreach (Position p in CurrentPositions())
            {
                if (!Position.IsValidColumn(p))
                {
                    return true;
                }
            }
            return false;
        }

        private Position[][] BuildTiles()
        {
            Position[][] positions = [];
            for (int i = 0; i < NumHoles; i++)
            {
                positions[0][i] = new Position(0, i);
                positions[1][i] = new Position(i, 0);
            }
            return positions;
        }
    }
}
