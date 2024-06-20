namespace Pieces;

class Case : Piece
{
    public Case()
    {   
    }
    public Case(Position position)
    {
        Color = -1;
        Name = ((position.X+position.Y)%2) != 0 ? " " : "■";
        Position = position;
    }

    public override void IsThreatened(Player oponent)
    {
        throw new NotImplementedException();
    }

    override
    public Position IsValidMove(Position position)
    {
        return new Position(-1, -1);
    }

    internal override bool CanCheck(Position position)
    {
        throw new NotImplementedException();
    }
}