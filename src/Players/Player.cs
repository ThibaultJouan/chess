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

/*
    public void InitPieces()
    {
        for(int i = 0; i < 8; i++)
        {
            pieces.Add(new Piece(white, "Pion", new Position(1, i)));
            pieces.Add(new Piece(, "Pion", new Position(1, i)));
        }
    }
    */
}