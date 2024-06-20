
namespace Pieces;

class Roi : Piece
{
    public bool isChecked { get; set; }
    public Roi()
    {   
    }
    public Roi(int color, string name, Position position)
    {   
        Color = color;
        Name = name;
        Position = position;
        isChecked = false;
    }


    override
    public Position IsValidMove(Position target)
    {
        if(Math.Abs(Position.X - target.X) > 1 || Math.Abs(Position.Y - target.Y) > 1)
            return new Position(-1,-1);

        return target;
    }

    public override void IsThreatened(Player oponent)
    {
        foreach(Piece piece in oponent.pieces)
        {
            if (piece.CanCheck(this.Position))
            {
                isChecked = true;
                Console.WriteLine($"ROI {this.Color} Echec !");
                return;
            }
            isChecked = false;
        }
    }

    internal override bool CanCheck(Position target)
    {
        return false;
    }
}