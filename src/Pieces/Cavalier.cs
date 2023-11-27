namespace Pieces;

class Cavalier : Piece
{
    public Cavalier()
    {   
    }
    public Cavalier(bool white, string name, Position position)
    {   
        this.white = white;
        this.name = name;
        this.position = position;
    }
}