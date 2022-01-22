using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Players
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(Color color) : base(color)
        {
        }

        public override Move MakeMove()
        {
            var inputSourceSquare = Console.ReadLine();
            var inputDestinationSquare = Console.ReadLine();

            var sourceSquare = ParseSquare(inputSourceSquare);
            var destinationSquare = ParseSquare(inputDestinationSquare);

            var piece = board.GetPlayerPieces(Color).Single(p => p.Position.Equals(sourceSquare));

            return new Move(piece, destinationSquare);
        }

        private Square ParseSquare(string text)
        {
            var file = Enum.Parse<File>(text[0].ToString());
            var rank = Enum.Parse<Rank>(text[1].ToString());

            return new Square(file, rank);
        }
    }
}
