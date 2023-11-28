namespace Pieces;

class Cavalier : Piece
{
    public Cavalier()
    {   
    }
    public Cavalier(bool white, string name, Position position)
    {   
        this.white = white;
        this.name = name;
        this.position = position;
    }

    override
    public Position IsValidMove(Position target)
    {
        if((Math.Abs(position.x - target.x) == 2 && Math.Abs(position.y - target.y) == 1)
         ||(Math.Abs(position.x - target.x) == 1 && Math.Abs(position.y - target.y) == 2))
        {
            return target;
        }
        return new Position(-1, -1);
    }
}