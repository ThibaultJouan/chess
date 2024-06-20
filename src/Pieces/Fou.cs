namespace Pieces;

class Fou : Piece
{
    public Fou()
    {   
    }
    public Fou(int color, string name, Position position)
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
        if(Math.Abs(this.Position.X - target.X) == Math.Abs(this.Position.Y - target.Y))
        {
            return target;
        }

        return new Position(-1, -1);
    }

    internal override bool CanCheck(Position targetKing)
    {
        //if(IsValidMove(targetKing).X != -1)
        //{

        //}
        return false;
    }
}