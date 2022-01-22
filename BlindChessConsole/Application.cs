using Core;
using Core.Pieces;
using Core.Players;
using System.Collections.Generic;

namespace BlindChessConsole
{
    public class Application
    {
        public void Run()
        {
            var board = new Board();
            board.Pieces = new List<Piece>
            {
                new King(board, new Square(File.a, Rank.One), Color.White),
                new Rook(board, new Square(File.a, Rank.Two), Color.White),
                new King(board, new Square(File.e, Rank.Four), Color.Black)
            };

            var game = new Game(board, new HumanPlayer(Color.White), new AIPlayer(Color.Black));

            game.Start();
        }
    }
}
