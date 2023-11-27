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
}