namespace Pieces;

class Tour : Piece
{
    public Tour()
    {   
    }
    public Tour(int white, string name, Position position)
    {   
        White = white;
        Name = name;
        Position = position;
    }

    override
    public Position IsValidMove(Position position)
    {
        if((Position.X == position.Y && Position.Y != position.Y) 
         ||(Position.Y == position.Y && Position.X != position.X))
            return position;
        return new Position(-1, -1);
    }
}