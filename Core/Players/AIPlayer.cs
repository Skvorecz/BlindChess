using Core.Pieces;
using System;
using System.Linq;

namespace Core.Players
{
    public class AIPlayer : PlayerBase
    {
        public AIPlayer(Color color) : base(color)
        {
        }

        public override Move MakeMove()
        {
            var king = board.GetPlayerPieces(Color).Single(p => p is King);
            var moves = king.GetPossibleMoves();

            var random = new Random();
            var randomSquare = moves[random.Next(moves.Count)];

            return new Move(king, randomSquare);
        }
    }
}
