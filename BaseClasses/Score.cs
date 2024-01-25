using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.BaseClasses
{
    public struct Score
    {
        public sbyte o = 1;
        public sbyte x = -1;
        public const sbyte tie = 0;
        public const sbyte inGame = 2;

        public Score(bool isStarting = true)
        {
            if(!isStarting)
            {
                x = (sbyte)-o;
                o = (sbyte)-x;
            }
        }

    }
}
