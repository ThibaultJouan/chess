namespace Pieces;

class Case : Piece
{
    public Case()
    {   
    }
    public Case(Position position)
    {
        White = -1;
        Name = ((position.X+position.Y)%2) != 0 ? " " : "■";
        Position = position;
    }

    override
    public Position IsValidMove(Position position)
    {
        return new Position(-1, -1);
    }
}