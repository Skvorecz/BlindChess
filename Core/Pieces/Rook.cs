using System.Collections.Generic;

namespace Core.Pieces
{
    public class Rook : Piece
    {
        public Rook(IBoard board) : base(board)
        {
        }

        public override List<Square> GetPossibleMoves()
        {
            var possibleMoves = new List<Square>();

            possibleMoves.AddRange(Board.GetUnblockedSquaresOnSameFile(Position));
            possibleMoves.AddRange(Board.GetUnblockedSquaresOnSameRank(Position));

            return possibleMoves;
        }
    }
}
