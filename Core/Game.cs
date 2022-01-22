using Core.Pieces;
using Core.Players;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class Game
    {
        private readonly IBoard board;
        private readonly IPlayer playerWhite;
        private readonly IPlayer playerBlack;

        public Game(IBoard board, IPlayer playerWhite, IPlayer playerBlack)
        {
            this.board = board;
            this.playerWhite = playerWhite;
            this.playerBlack = playerBlack;
        }

        public void Start()
        {
            while (true)
            {
                playerWhite.MakeMove();
                if(board.IsItCheckmate(playerWhite.Color))
                {
                    Console.WriteLine("Checkmate. White has won.");
                    return;
                }
                if(board.IsItStatemate(playerWhite.Color))
                {
                    Console.WriteLine("Statemate. Draw.");
                    return;
                }

                playerBlack.MakeMove();
            }
        }
    }
}
