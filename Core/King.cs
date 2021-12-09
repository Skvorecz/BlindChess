using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class King : Piece
    {
        public King(IBoard board) : base(board)
        {
        }

        public override List<Square> GetPossibleMoves()
        {
            var possibleMoves = new List<Square>();

            possibleMoves.Add(Board.GetSquareOnTheLeft(Position));
            possibleMoves.Add(Board.GetSquareOnTheLeftAndAbove(Position));
            possibleMoves.Add(Board.GetSquareAbove(Position));
            possibleMoves.Add(Board.GetSquareOnTheRightAndAbove(Position));
            possibleMoves.Add(Board.GetSquareOnTheRight(Position));
            possibleMoves.Add(Board.GetSquareOnTheRightAndBelow(Position));
            possibleMoves.Add(Board.GetSquareBelow(Position));
            possibleMoves.Add(Board.GetSquareOnTheLeftAndBelow(Position));

            return possibleMoves;
        }
    }
}
