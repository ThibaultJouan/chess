using System;

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
        string show = "";
        for(int i = 0; i < height; i++)
        {
            for(int j = 0; j < width; j++)
            {
                show += this.board[i,j].ToString() + " ";
            }
            show += System.Environment.NewLine;
        }

        return show;
    }
}