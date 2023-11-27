using System;
using System.ComponentModel;

namespace Pieces;
class Piece
{
    public bool white {get; private set;}
    public string name {get; private set;}
    public Position position {get; set;}

    public Piece(bool white, string name, Position position)
    {   
        this.white = white;
        this.name = name;
        this.position = position;
    }

    //TODO: liste de coups jouables
    //TODO: 'Score' de chaque coup
}