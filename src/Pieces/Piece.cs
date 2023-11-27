using System;
using System.ComponentModel;

namespace Pieces;
class Piece
{
    public bool white {get; set;}
    public string name {get; set;}
    public Position position {get; set;}

    public Piece()
    {
        this.name = String.Empty;
        this.position = new Position(0,0);
    }
    public Piece(bool white, string name, Position position)
    {   
        this.white = white;
        this.name = name;
        this.position = position;
    }

    //TODO: liste de coups jouables
    //TODO: 'Score' de chaque coup
}