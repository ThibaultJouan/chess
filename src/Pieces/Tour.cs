namespace Pieces;

class Tour : Piece
{
    public Tour()
    {   
    }
    public Tour(bool white, string name, Position position)
    {   
        this.white = white;
        this.name = name;
        this.position = position;
    }

    override
    public Position IsValidMove(Position position)
    {
        if((this.position.x == position.y && this.position.y != position.y) 
         ||(this.position.y == position.y && this.position.x != position.x))
            return position;
        return new Position(-1, -1);
    }
}