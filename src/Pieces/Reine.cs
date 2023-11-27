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
}