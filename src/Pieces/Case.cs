namespace Pieces;

class Case : Piece
{
    public Case()
    {   
    }
    public Case(Position position)
    {   
        this.name = ((position.x+position.y)%2) != 0 ? " " : "■";

        this.position = position;
    }


    override
    public Position IsValidMove(Position position)
    {
        return new Position(-1, -1);
    }
}