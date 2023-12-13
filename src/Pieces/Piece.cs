using System;
using System.ComponentModel;

namespace Pieces;
abstract class Piece
{
    public int White {get; set;}
    public string Name {get; set;}
    public Position Position {get; set;}

    public Piece()
    {
        Name = String.Empty;
        Position = new Position(0,0);
    }
    public Piece(int white, string name, Position position)
    {   
        White = white;
        Name = name;
        Position = position;
    }

    public abstract Position IsValidMove(Position target);
    //TODO: liste de coups jouables
    //TODO: 'Score' de chaque coup
}