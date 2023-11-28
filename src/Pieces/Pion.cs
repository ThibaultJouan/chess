namespace Pieces;

class Pion : Piece
{
    public bool firstMove;
    public Pion()
    {   
    }
    public Pion(bool white, string name, Position position)
    {   
        this.firstMove = true;
        this.white = white;
        this.name = name;
        this.position = position;
    }


    override
    public Position IsValidMove(Position target)
    {
        int step = 1;
        if((white && position.x == 1) || (!white && position.x == 6))
        {
            step = 2;
        }

        if(white && position.x - target.x >= -step && position.y == target.y)
            return target;
        
        if(!white && position.x - target.x <= step && position.y == target.y)
            return target;

        return new Position(-1,-1);
    }

}