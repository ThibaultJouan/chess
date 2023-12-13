namespace Pieces;

class Reine : Piece
{
    public Reine()
    {   
    }
    public Reine(int white, string name, Position position)
    {   
        White = white;
        Name = name;
        Position = position;
    }


    override
    public Position IsValidMove(Position target)
    {
        if(((Position.X == target.Y && Position.Y != target.Y) 
         ||(Position.Y == target.Y && Position.X != target.X))
         ||Math.Abs(Position.X - target.X) == Math.Abs(Position.Y - target.Y))
            return Position;
        return new Position(-1, -1);
    }
}