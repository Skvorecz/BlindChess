using System.Collections.Generic;

namespace Core
{
    public class Rook : Piece
    {
        public Rook(IBoard board) : base(board)
        {
        }

        public override List<Square> GetPossibleMoves()
        {
            var possibleMoves = new List<Square>();

            possibleMoves.AddRange(Board.GetOtherSquaresOnSameFile(Position));
            possibleMoves.AddRange(Board.GetOtherSquaresOnSameRank(Position));

            return possibleMoves;
        }
    }
}
