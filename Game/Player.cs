using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.BaseClasses;

namespace TicTacToe.Game
{
    public class Player
    {
        public readonly char symbol;
        public readonly Score score;

        public Player(bool isStarting)
        {
            score = new Score(isStarting);
            if (isStarting) symbol = 'X';
            else symbol = 'O';
        }
    }
}
