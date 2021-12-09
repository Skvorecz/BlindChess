using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public struct Square
    {
        public File File { get; }
        public Rank Rank { get; }

        public Square(File file, Rank rank)
        {
            File = file;
            Rank = rank;
        }

        public bool Equals(Square square)
        {
            return this.File == square.File
                && this.Rank == square.Rank;
        }
    }
}
