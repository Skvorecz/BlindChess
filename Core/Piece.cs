using System.Collections.Generic;

namespace Core
{
    public abstract class Piece
    {
        protected IBoard Board { get; }

        public Square Position { get; }
        public Color Color { get; }

        protected Piece(IBoard board)
        {
            Board = board;
        }

        public abstract List<Square> GetPossibleMoves();
    }
}
