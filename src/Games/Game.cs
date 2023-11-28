
using Pieces;

class Game
{
    private Player white;
    private Player black;
    private Board board;
    private int turns;
    private List<Piece> pieces;
    public Game()
    {
        this.board = new Board(8,8);
        this.turns = 0;
        this.white = new Player(true);
        this.black = new Player(false);
        this.pieces = new List<Piece>();
    }

    public void StartGame()
    {
        Board board = new Board(8,8);

        board.InitBoard();
        this.turns++;
        InitPieces();
        board.PopulateBoard(this.pieces);
        System.Console.Write(board.ShowBoard());

        PlayTurn();
    }

    public void PlayTurn()
    {
        string input = System.Console.ReadLine();

        Position start = new Position(input.Substring(0,2));
        Position destination = new Position(input.Substring(2,2));
        Piece toMove = board.board[start.x, start.y];
        Position test = toMove.IsValidMove(destination);
        
        while(test.x == -1)
        {
            input = System.Console.ReadLine();
            start = new Position(input.Substring(0,2));
            destination = new Position(input.Substring(2,2));
            toMove = board.board[start.x, start.y];
            test = toMove.IsValidMove(destination);
        }

        toMove.position.SetPosition(destination);
        board.board[start.x, start.y] = new Case(start);
        board.board[toMove.position.x, toMove.position.y] = toMove;
        Console.Write(board.ShowBoard());      
    }

    public void InitPieces()
    {
        for(int i = 0; i < 8; i++)
        {
            white.pieces.Add(new Pion(true, "Pion", new Position(1, i)));
            black.pieces.Add(new Pion(false, "Pion", new Position(6, i)));
        }

        white.pieces.Add(new Cavalier(true, "Cavalier", new Position(0, 1)));
        white.pieces.Add(new Cavalier(true, "Cavalier", new Position(0, 6)));

        black.pieces.Add(new Cavalier(false, "Cavalier", new Position(7, 1)));
        black.pieces.Add(new Cavalier(false, "Cavalier", new Position(7, 6)));

        white.pieces.Add(new Fou(true, "Fou", new Position(0, 2)));
        white.pieces.Add(new Fou(true, "Fou", new Position(0, 5)));

        black.pieces.Add(new Fou(false, "Fou", new Position(7, 2)));
        black.pieces.Add(new Fou(false, "Fou", new Position(7, 5)));

        white.pieces.Add(new Tour(true, "Tour", new Position(0, 0)));
        white.pieces.Add(new Tour(true, "Tour", new Position(0, 7)));

        black.pieces.Add(new Tour(false, "Tour", new Position(7, 0)));
        black.pieces.Add(new Tour(false, "Tour", new Position(7, 7)));

        black.pieces.Add(new Reine(true, "Reine", new Position(0, 3)));
        black.pieces.Add(new Reine(false, "Reine", new Position(7, 3)));

        black.pieces.Add(new Roi(true, "KRoi", new Position(0, 4)));
        black.pieces.Add(new Roi(false, "KRoi", new Position(7, 4)));

        this.pieces.AddRange(white.pieces);
        this.pieces.AddRange(black.pieces);
    }
}