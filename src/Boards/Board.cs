using System.Text;
using Pieces;

class Board
{
    private readonly int _height;
    private readonly int _width;
    public Piece[,] board;

    public Board(int height, int width)
    {
        this._height = height;
        this._width = width;
        this.board = new Piece[height, width];
    }

    public void InitBoard()
    {
        for(int i = 0; i < _height; i++)
            for(int j = 0; j < _width; j++)
            {
                this.board[i,j] = new Case(new Position(i,j));
            }
    }

    public string ShowBoard()
    {
        var show = new StringBuilder[8];
        var final = new StringBuilder();
        var part = new StringBuilder("", _width*2);

        for(int i = 0; i < _height; i++)
        {
            for(int j = 0; j < _width; j++)
            {
                part.Append(this.board[i,j].Name[0].ToString() + " ");
            }
            show[7-i] = new StringBuilder(part.Length);
            show[7-i].Append(part);
            part = new StringBuilder("", _width*2);
        }
        return final.AppendJoin(System.Environment.NewLine, show.ToList()).ToString();
    }

    public void PopulateBoard(List<Piece> pieces)
    {
        foreach(Piece p in pieces)
        {
            this.board[p.Position.X, p.Position.Y] = p;
            this.board[p.Position.X, p.Position.Y].Name = p.Name[0].ToString();
        }
    }
}