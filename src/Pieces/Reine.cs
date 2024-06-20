namespace Pieces;

class Reine : Piece
{
    public Reine()
    {   
    }
    public Reine(int color, string name, Position position)
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
    public Position IsValidMove(Position target)
    {
        if(((Position.X == target.Y && Position.Y != target.Y) 
         ||(Position.Y == target.Y && Position.X != target.X))
         ||Math.Abs(Position.X - target.X) == Math.Abs(Position.Y - target.Y))
            return Position;
        return new Position(-1, -1);
    }

    internal override bool CanCheck(Position position)
    {
        return false;
    }
}