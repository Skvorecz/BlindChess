using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Game
    {
        private List<Piece> pieces;

        private IEnumerable<Square> OccupiedSquares => pieces.Select(p => p.Position);

        public bool IsSquareOccupied(Square square) => OccupiedSquares.Any(s => s.Equals(square));
        public bool IsSquareFree(Square square) => !IsSquareOccupied(square);
    }
}
