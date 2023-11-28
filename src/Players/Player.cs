using System;

using Pieces;

class Player
{
    private bool white {get; set;}
    private int score {get; set;}
    public List<Piece> pieces;
    public Player(bool white)
    {
        this.white = white;
        this.score = 0;
        this.pieces = new List<Piece>();
    }
}