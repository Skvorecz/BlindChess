using Core.Pieces;
using System.Collections.Generic;

namespace Core
{
    public interface IBoard
    {
        List<Square> GetOtherSquaresOnSameFile(Square square);
        List<Square> GetOtherSquaresOnSameRank(Square square);
        List<Piece> GetPlayerPieces(Color playerColor);
        Square GetSquareAbove(Square square);
        Square GetSquareBelow(Square square);
        Square GetSquareOnTheLeft(Square square);
        Square GetSquareOnTheLeftAndAbove(Square square);
        Square GetSquareOnTheLeftAndBelow(Square square);
        Square GetSquareOnTheRight(Square square);
        Square GetSquareOnTheRightAndAbove(Square square);
        Square GetSquareOnTheRightAndBelow(Square square);
        List<Square> GetUnblockedSquaresOnSameFile(Square square);
        List<Square> GetUnblockedSquaresOnSameRank(Square square);
        bool IsItCheckmate(Color nextPlayerColor);
        bool IsItStatemate(Color nextPlayerColor);
        bool IsSquareCheckedByOpponent(Square square, Color yourColor);
        bool IsSquareFree(Square square);
        bool IsSquareOccupied(Square square);
        bool IsThereSquareAbove(Square square);
        bool IsThereSquareBelow(Square square);
        bool IsThereSquareOnTheLeft(Square square);
        bool IsThereSquareOnTheLeftAndAbove(Square square);
        bool IsThereSquareOnTheLeftAndBelow(Square square);
        bool IsThereSquareOnTheRight(Square square);
        bool IsThereSquareOnTheRightAndAbove(Square square);
        bool IsThereSquareOnTheRightAndBelow(Square square);
    }
}