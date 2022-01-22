using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Players
{
    public abstract class Player : IPlayer
    {
        protected readonly IBoard board;
        public Color Color { get; }

        protected Player(Color color)
        {
            Color = color;
        }

        public abstract Move MakeMove();
    }
}
