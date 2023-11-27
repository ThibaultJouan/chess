namespace Pieces;

class Pion : Piece
{
    public Pion()
    {   
    }
    public Pion(bool white, string name, Position position)
    {   
        this.white = white;
        this.name = name;
        this.position = position;
    }


    public Position IsValidMove(Position target)
    {
        if(white && position.x - target.x == -1 && position.y == target.y)
            return target;
        
        if(!white && position.x - target.x == 1 && position.y == target.y)
            return target;

        return new Position(-1,-1);
    }

}