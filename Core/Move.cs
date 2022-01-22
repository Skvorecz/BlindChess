using Core.Pieces;

namespace Core
{
    public class Move
    {
        Piece Piece { get; }
        Square DestinationSquare { get; }

        public Move(Piece piece, Square destinationSquare)
        {
            Piece = piece;
            DestinationSquare = destinationSquare;
        }
    }
}
