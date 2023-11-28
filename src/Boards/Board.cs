using System.Text;
using Pieces;

class Board
{
    private int height;
    private int width;
    public Piece[,] board;

    public Board(int height, int width)
    {
        this.height = height;
        this.width = width;
        this.board = new Piece[height, width];
    }

    public void InitBoard()
    {
        for(int i = 0; i < height; i++)
            for(int j = 0; j < width; j++)
            {
                this.board[i,j] = new Case(new Position(i,j));
            }
    }

    public string ShowBoard()
    {
        var show = new StringBuilder[8];
        var final = new StringBuilder();
        var part = new StringBuilder("", width*2);

        for(int i = 0; i < height; i++)
        {
            for(int j = 0; j < width; j++)
            {
                part.Append(this.board[i,j].name[0].ToString() + " ");
            }
            show[7-i] = new StringBuilder(part.Length);
            show[7-i].Append(part);
            part = new StringBuilder("", width*2);
        }

        return final.AppendJoin(System.Environment.NewLine, show.ToList()).ToString();
    }

    public void PopulateBoard(List<Piece> pieces)
    {
        foreach(Piece p in pieces)
        {
            this.board[p.position.x, p.position.y] = p;
            this.board[p.position.x, p.position.y].name = p.name[0].ToString();
        }
    }
}