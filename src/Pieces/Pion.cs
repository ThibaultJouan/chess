namespace Pieces;

class Pion : Piece
{
    public bool firstMove;
    public Pion()
    {   
    }
    public Pion(int white, string name, Position position)
    {   
        firstMove = true;
        White = white;
        Name = name;
        Position = position;
    }


    override
    public Position IsValidMove(Position target)
    {
        int step = 1;
        if((White == 1 && Position.X == 1) || (White == 0 && Position.X == 6))
        {
            step = 2;
        }

        if(White == 1 && Position.X - target.X >= -step && Position.Y == target.Y)
            return target;
        
        if(White == 0 && Position.X - target.X <= step && Position.Y == target.Y)
            return target;

        return new Position(-1,-1);
    }

}