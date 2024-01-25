using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.BaseClasses
{
    public class Board
    {
        private string board = String.Empty;

        public string CleanBoard() => board = new string(' ', 9);

        public bool IsBoardFull()
        {
            if (board.All(e => !char.IsWhiteSpace(e))) return true;
            return false;
        }

        public Board() {
            CleanBoard();
        }

        public char Read(Position position)
        {
            return board[position.GetPosition];
        }

        public string DisplayBoard()
        {
            string value = String.Empty;

            for (int i = 0; i <= 6; i += 3) {
                value += "\n" + board[i] + '|' + board[i + 1] + '|' + board[i + 2];
                if(i != 6) value += "\n-----";
            }

            return value;
        }

        public bool Write(Position position, char value)
        {
            char[] array = board.ToCharArray();

            if (array[position.GetPosition] == ' ')
            {
                array[position.GetPosition] = value;
                board = new string(array);
                return true;
            }

            return false;
        }
    }
}
