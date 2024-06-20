
using Pieces;

class Player
{
    public int Color {get; set;}
    private int Score { get; set; }
    public List<Piece> pieces;
    public Player(int color)
    {
        this.Color = color;
        this.Score = 0;
        this.pieces = new List<Piece>();
    }
}