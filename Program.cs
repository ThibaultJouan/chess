using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8,8);

            board.InitBoard();

            

            Console.WriteLine(board.ShowBoard());
        }
    }
}