namespace Pieces;

class Fou : Piece
{
    public Fou()
    {   
    }
    public Fou(bool white, string name, Position position)
    {   
        this.white = white;
        this.name = name;
        this.position = position;
    }


    override
    public Position IsValidMove(Position target)
    {
        if(Math.Abs(this.position.x - target.x) == Math.Abs(this.position.y - target.y))
        {
            return target;
        }

        return new Position(-1, -1);
    }
}