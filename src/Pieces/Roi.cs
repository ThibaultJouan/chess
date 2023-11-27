
namespace Pieces;

class Roi : Piece
{
    public Roi()
    {   
    }
    public Roi(bool white, string name, Position position)
    {   
        this.white = white;
        this.name = name;
        this.position = position;
    }

    public Position IsValidMove(Position target)
    {
        if(Math.Abs(this.position.x - target.x) > 1 || Math.Abs(this.position.y - target.y) > 1)
            return new Position(-1,-1);

        return target;
    }
}