namespace Pieces;

class Tour : Piece
{
    public Tour()
    {   
    }
    public Tour(int color, string name, Position position)
    {   
        Color = color;
        Name = name;
        Position = position;
    }

    public override void IsThreatened(Player oponent)
    {
        throw new NotImplementedException();
    }

    override
    public Position IsValidMove(Position position)
    {
        if((Position.X == position.Y && Position.Y != position.Y) 
         ||(Position.Y == position.Y && Position.X != position.X))
            return position;
        return new Position(-1, -1);
    }

    internal override bool CanCheck(Position position)
    {
        return false;
    }
}