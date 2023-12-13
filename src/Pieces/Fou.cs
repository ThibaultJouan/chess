namespace Pieces;

class Fou : Piece
{
    public Fou()
    {   
    }
    public Fou(int white, string name, Position position)
    {   
        White = white;
        Name = name;
        Position = position;
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
}