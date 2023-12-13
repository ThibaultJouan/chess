namespace Pieces;

class Cavalier : Piece
{
    public Cavalier()
    {   
    }
    public Cavalier(int white, string name, Position position)
    {   
        White = white;
        Name = name;
        Position = position;
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
}