using System.Collections.Generic;
using System.Linq;

namespace Core.Pieces
{
    public class King : Piece
    {
        public King(IBoard board, Square position, Color color) : base(board, position, color)
        {
        }

        public override List<Square> GetPossibleMoves()
        {
            var potentialPossibleMoves = new List<Square>();

            potentialPossibleMoves.Add(Board.GetSquareOnTheLeft(Position));
            potentialPossibleMoves.Add(Board.GetSquareOnTheLeftAndAbove(Position));
            potentialPossibleMoves.Add(Board.GetSquareAbove(Position));
            potentialPossibleMoves.Add(Board.GetSquareOnTheRightAndAbove(Position));
            potentialPossibleMoves.Add(Board.GetSquareOnTheRight(Position));
            potentialPossibleMoves.Add(Board.GetSquareOnTheRightAndBelow(Position));
            potentialPossibleMoves.Add(Board.GetSquareBelow(Position));
            potentialPossibleMoves.Add(Board.GetSquareOnTheLeftAndBelow(Position));

            return potentialPossibleMoves.Where(m => IsMovePossible(m)).ToList();
        }

        private bool IsMovePossible(Square square)
        {
            return Board.IsSquareFree(square)
                && Board.IsSquareCheckedByOpponent(square, Color);
        }
    }
}