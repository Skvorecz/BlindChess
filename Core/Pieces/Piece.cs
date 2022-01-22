using System.Collections.Generic;

namespace Core.Pieces
{
    public abstract class Piece
    {
        protected IBoard Board { get; }

        public Square Position { get; }
        public Color Color { get; }

        protected Piece(IBoard board, Square position, Color color)
        {
            Board = board;
            Position = position;
            Color = color;
        }

        public abstract List<Square> GetPossibleMoves();
    }
}
