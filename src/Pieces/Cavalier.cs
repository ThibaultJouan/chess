namespace Pieces;

class Cavalier : Piece
{
    public Cavalier()
    {   
    }
    public Cavalier(int color, string name, Position position)
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
        if((Math.Abs(Position.X - target.X) == 2 && Math.Abs(Position.Y - target.Y) == 1)
         ||(Math.Abs(Position.X - target.X) == 1 && Math.Abs(Position.Y - target.Y) == 2))
        {
            return target;
        }
        return new Position(-1, -1);
    }

    internal override bool CanCheck(Position targetKing)
    {
        return IsValidMove(targetKing).X != -1;
    }
}