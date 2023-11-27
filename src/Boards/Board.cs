using System;
using System.Text;
using System.ComponentModel;
using Pieces;

class Board
{
    private int height;
    private int width;
    private char[,] board;
    public Board(int height, int width)
    {
        this.height = height;
        this.width = width;
        this.board = new char[height, width];
    }

    public void InitBoard()
    {
        for(int i = 0; i < height; i++)
            for(int j = 0; j < width; j++)
            {
                this.board[i,j] = ((i+j)%2) == 0 ? ' ' : '■' ;
            }
    }

    public string ShowBoard()
    {
        var show = new StringBuilder("", height*width*2);
        var part = new StringBuilder("", width*2);
        for(int i = 0; i < height; i++)
        {
            for(int j = 0; j < width; j++)
            {
                part.Append(this.board[i,j].ToString() + " ");
            }
            show.Append(part + System.Environment.NewLine);
            part = new StringBuilder("", width*2);
        }

        return show.ToString();
    }

    public void PopulateBoard(List<Piece> pieces)
    {
        foreach(Piece p in pieces)
        {
            this.board[p.position.x, p.position.y] = p.name[0];
        }
    }
}