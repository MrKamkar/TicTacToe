using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.BaseClasses
{
    public static class ByteOperations
    {
        public static bool KeyToByte(char keyChar, ref byte variable)
        {
            byte newValue;
            if (byte.TryParse(keyChar.ToString(), out newValue))
            {
                variable = newValue;
                return true;
            }
            return false;
        }
    }
}
