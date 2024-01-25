using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.BaseClasses
{
    public class Position
    {
        private byte row = 0;
        public byte Row
        {
            get => row;
            set { if (value < 3) row = value; }
        }

        private byte column = 0;
        public byte Column
        {
            get => column; 
            set { if (value < 3) column = value; }
        }

        public byte GetPosition { get => (byte)(Row * 3 + Column); }

        public Position(byte row, byte column)
        {
            this.Row = row;
            this.Column = column;
        }
    }
}
