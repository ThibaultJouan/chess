namespace Pieces;

class Pion : Piece
{
    public bool firstMove;
    public Pion()
    {   
    }
    public Pion(int color, string name, Position position)
    {   
        firstMove = true;
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
        int step = 1;
        if((Color == 1 && Position.X == 1) || (Color == 0 && Position.X == 6))
        {
            step = 2;
        }

        if(Color == 1 && Position.X - target.X >= -step && Position.Y == target.Y)
            return target;
        
        if(Color == 0 && Position.X - target.X <= step && Position.Y == target.Y)
            return target;

        return new Position(-1,-1);
    }

    internal override bool CanCheck(Position position)
    {
        return false;
    }
}