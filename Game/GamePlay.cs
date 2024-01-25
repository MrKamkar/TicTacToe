using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.BaseClasses;

namespace TicTacToe.GamePlay
{
    public static class Game
    {
        private static sbyte ReturnWinner(char winner, Score score)
        {
            if (winner == 'X') return score.x;
            return score.o;
        }

        public static sbyte CheckWinner(Score score, Board board)
        {
            char winner;
            for (byte i = 0; i < 3; i++) {
                winner = board.Read(new Position(i, 0));
                if ((winner == board.Read(new Position(i, 1))) && (winner == board.Read(new Position(i, 2)))) return ReturnWinner(winner, score);

                winner = board.Read(new Position(0, i));
                if ((winner == board.Read(new Position(1, i))) && (winner == board.Read(new Position(2, i)))) return ReturnWinner(winner, score);
            }

            winner = board.Read(new Position(1, 1));
            if((winner == board.Read(new Position(0, 2)) && winner == board.Read(new Position(2, 0))) || (winner == board.Read(new Position(0, 0)) && winner == board.Read(new Position(2, 2)))) return ReturnWinner(winner, score);

            if (board.IsBoardFull()) return Score.tie;
            return Score.inGame;
        }
    }
}
