namespace Pieces;

class Reine : Piece
{
    public Reine()
    {   
    }
    public Reine(bool white, string name, Position position)
    {   
        this.white = white;
        this.name = name;
        this.position = position;
    }


    override
    public Position IsValidMove(Position target)
    {
        if(((this.position.x == target.y && this.position.y != target.y) 
         ||(this.position.y == target.y && this.position.x != target.x))
         ||Math.Abs(this.position.x - target.x) == Math.Abs(this.position.y - target.y))
            return position;
        return new Position(-1, -1);
    }
}