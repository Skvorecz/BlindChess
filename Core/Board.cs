using Core.Pieces;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class Board : IBoard
    {
        private const File LeftFile = File.a;
        private const File RightFile = File.h;
        private const Rank BottomRank = Rank.One;
        private const Rank TopRank = Rank.Eight;

        private List<Piece> pieces;             

        private bool IsSquareOccupied(Square square) => OccupiedSquares.Any(s => s.Equals(square));
        private bool IsSquareFree(Square square) => !IsSquareOccupied(square);
        private IEnumerable<Square> OccupiedSquares => pieces.Select(p => p.Position);

        public bool IsThereSquareOnTheLeft(Square square) => square.File != LeftFile;
        public bool IsThereSquareOnTheRight(Square square) => square.File != RightFile;
        public bool IsThereSquareBelow(Square square) => square.Rank != BottomRank;
        public bool IsThereSquareAbove(Square square) => square.Rank != TopRank;

        public bool IsThereSquareOnTheLeftAndBelow(Square square) => IsThereSquareOnTheLeft(square) && IsThereSquareBelow(square);
        public bool IsThereSquareOnTheRightAndBelow(Square square) => IsThereSquareOnTheRight(square) && IsThereSquareBelow(square);
        public bool IsThereSquareOnTheLeftAndAbove(Square square) => IsThereSquareOnTheLeft(square) && IsThereSquareAbove(square);
        public bool IsThereSquareOnTheRightAndAbove(Square square) => IsThereSquareOnTheRight(square) && IsThereSquareAbove(square);

        public Square GetSquareOnTheLeft(Square square) => new Square(square.File - 1, square.Rank);
        public Square GetSquareOnTheRight(Square square) => new Square(square.File + 1, square.Rank);
        public Square GetSquareBelow(Square square) => new Square(square.File, square.Rank - 1);
        public Square GetSquareAbove(Square square) => new Square(square.File, square.Rank + 1);

        public Square GetSquareOnTheLeftAndBelow(Square square) => new Square(square.File - 1, square.Rank - 1);
        public Square GetSquareOnTheRightAndBelow(Square square) => new Square(square.File + 1, square.Rank - 1);
        public Square GetSquareOnTheLeftAndAbove(Square square) => new Square(square.File - 1, square.Rank + 1);
        public Square GetSquareOnTheRightAndAbove(Square square) => new Square(square.File + 1, square.Rank + 1);

        public List<Square> GetOtherSquaresOnSameFile(Square square)
        {
            var squares = new List<Square>();
            var currentSquare = square;
            while (IsThereSquareBelow(currentSquare))
            {
                currentSquare = GetSquareBelow(square);
                squares.Add(currentSquare);
            }

            currentSquare = square;
            while (IsThereSquareAbove(currentSquare))
            {
                currentSquare = GetSquareAbove(square);
                squares.Add(currentSquare);
            }

            return squares;
        }

        public List<Square> GetOtherSquaresOnSameRank(Square square)
        {
            var squares = new List<Square>();
            var currentSquare = square;
            while (IsThereSquareOnTheLeft(currentSquare))
            {
                currentSquare = GetSquareOnTheLeft(square);
                squares.Add(currentSquare);
            }

            currentSquare = square;
            while (IsThereSquareOnTheRight(currentSquare))
            {
                currentSquare = GetSquareOnTheRight(square);
                squares.Add(currentSquare);
            }

            return squares;
        }

        public List<Square> GetUnblockedSquaresOnSameFile(Square square)
        {
            var squares = new List<Square>();
            var currentSquare = square;
            while (IsThereSquareBelow(currentSquare))
            {
                currentSquare = GetSquareBelow(square);
                if(IsSquareOccupied(currentSquare))
                {
                    break;
                }

                squares.Add(currentSquare);
            }

            currentSquare = square;
            while (IsThereSquareAbove(currentSquare))
            {
                currentSquare = GetSquareAbove(square);
                if (IsSquareOccupied(currentSquare))
                {
                    break;
                }

                squares.Add(currentSquare);
            }

            return squares;
        }

        public List<Square> GetUnblockedSquaresOnSameRank(Square square)
        {
            var squares = new List<Square>();
            var currentSquare = square;
            while (IsThereSquareOnTheLeft(currentSquare))
            {
                currentSquare = GetSquareOnTheLeft(square);
                if (IsSquareOccupied(currentSquare))
                {
                    break;
                }

                squares.Add(currentSquare);
            }

            currentSquare = square;
            while (IsThereSquareOnTheRight(currentSquare))
            {
                currentSquare = GetSquareOnTheRight(square);
                if (IsSquareOccupied(currentSquare))
                {
                    break;
                }

                squares.Add(currentSquare);
            }

            return squares;
        }
    }
}
