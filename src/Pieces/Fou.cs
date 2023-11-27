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
}