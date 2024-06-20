using System;
using System.ComponentModel;

namespace Pieces;
abstract class Piece
{
    public int Color {get; set;}
    public string Name {get; set;}
    public Position Position {get; set;}

    public Piece()
    {
        Name = String.Empty;
        Position = new Position(0,0);
    }
    public Piece(int color, string name, Position position)
    {   
        Color = color;
        Name = name;
        Position = position;
    }

    public abstract Position IsValidMove(Position target);

    internal abstract bool CanCheck(Position position);
    public abstract void IsThreatened(Player oponent);

    //TODO: liste de coups jouables
    //TODO: 'Score' de chaque coup
}