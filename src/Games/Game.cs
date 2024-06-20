using Pieces;

class Game
{
    private readonly Player _white;
    private readonly Player _black;
    private Board _board;
    private int _turns;
    private List<Piece> _pieces;
    public Game()
    {
        this._board = new Board(8,8);
        this._turns = 0;
        this._white = new Player(1);
        this._black = new Player(0);
        this._pieces = new List<Piece>();
    }
    public void StartGame()
    {
        this._board = new Board(8,8);

        this._board.InitBoard();
        this._turns++;
        InitPieces();
        this._board.PopulateBoard(this._pieces);
        System.Console.Write(this._board.ShowBoard());

        for(int i = 0; i < 15; i++)
        {
            PlayTurn(this._white.Color);
            PlayTurn(this._black.Color);
        }
    }

    public void PlayTurn(int color)
    {
        string input = ReadTrueLine();

        Position start = new(input[..2]);
        Position destination = new(input.Substring(2, 2));
        Piece toMove = _board.board[start.X, start.Y];
        Position testValidMove = toMove.IsValidMove(destination);
        
        while(testValidMove.X == -1 || toMove.Color != color || _board.board[start.X, start.Y].Color == _board.board[destination.X, destination.Y].Color)
        {
            input = ReadTrueLine();
            start = new(input[..2]);
            destination = new(input.Substring(2, 2));
            toMove = _board.board[start.X, start.Y];
            testValidMove = toMove.IsValidMove(destination);
        }

        toMove.Position.SetPosition(destination);
        _board.board[start.X, start.Y] = new Case(start);
        _board.board[toMove.Position.X, toMove.Position.Y] = toMove;

        Player oponent;

        if(color == 1)
        {
            oponent = _black;
        }
        else
        {
            oponent = _white;
        }

        foreach(Piece piece in oponent.pieces)
        {
            if(piece.Color != color && piece.GetType() == typeof(Roi))
            {
                piece.IsThreatened(oponent);
                break;
            }
        }

        Console.Write(_board.ShowBoard());      
    }

    public static string ReadTrueLine()
    {
        var input = Console.ReadLine();
        while(input == null || input.Length < 4)
        {
            input = Console.ReadLine();
        }
        return input.ToString().ToLowerInvariant();
    }
    public void InitPieces()
    {
        _white.pieces.Add(new Roi(1, "K", new Position(0, 4)));
        _black.pieces.Add(new Roi(0, "k", new Position(7, 4)));

        for (int i = 0; i < 8; i++)
        {
            _white.pieces.Add(new Pion(1, "P", new Position(1, i)));
            _black.pieces.Add(new Pion(0, "p", new Position(6, i)));
        }

        _white.pieces.Add(new Cavalier(1, "C", new Position(0, 1)));
        _white.pieces.Add(new Cavalier(1, "C", new Position(0, 6)));

        _black.pieces.Add(new Cavalier(0, "c", new Position(7, 1)));
        _black.pieces.Add(new Cavalier(0, "c", new Position(7, 6)));

        _white.pieces.Add(new Fou(1, "F", new Position(0, 2)));
        _white.pieces.Add(new Fou(1, "F", new Position(0, 5)));

        _black.pieces.Add(new Fou(0, "f", new Position(7, 2)));
        _black.pieces.Add(new Fou(0, "f", new Position(7, 5)));

        _white.pieces.Add(new Tour(1, "T", new Position(0, 0)));
        _white.pieces.Add(new Tour(1, "T", new Position(0, 7)));

        _black.pieces.Add(new Tour(0, "t", new Position(7, 0)));
        _black.pieces.Add(new Tour(0, "t", new Position(7, 7)));

        _white.pieces.Add(new Reine(1, "Q", new Position(0, 3)));
        _black.pieces.Add(new Reine(0, "q", new Position(7, 3)));

        _pieces.AddRange(_white.pieces);
        _pieces.AddRange(_black.pieces);
    }
}