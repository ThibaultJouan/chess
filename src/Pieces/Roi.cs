
namespace Pieces;

class Roi : Piece
{
    public Roi()
    {   
    }
    public Roi(int white, string name, Position position)
    {   
        White = white;
        Name = name;
        Position = position;
    }


    override
    public Position IsValidMove(Position target)
    {
        if(Math.Abs(Position.X - target.X) > 1 || Math.Abs(Position.Y - target.Y) > 1)
            return new Position(-1,-1);

        return target;
    }
}