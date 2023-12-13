
using Pieces;

class Player
{
    public int White {get; set;}
    private int Score { get; set; }
    public List<Piece> pieces;
    public Player(int white)
    {
        this.White = white;
        this.Score = 0;
        this.pieces = new List<Piece>();
    }
}