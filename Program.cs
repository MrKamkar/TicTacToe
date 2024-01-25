
using TicTacToe.BaseClasses;
using TicTacToe.Game;

class Program
{

    static void Main(string[] args)
    {
        Board board = new Board();
        Player player = new Player(true);

        while(true)
        {
            Console.WriteLine(board.DisplayBoard());

            byte x = 0, y = 0;
            do
            {
                do
                {
                    Console.Write("\nPodaj współrzędną X: ");
                } while (!ByteOperations.KeyToByte(Console.ReadKey().KeyChar, ref x));

                do
                {
                    Console.Write("\nPodaj współrzędną Y: ");
                } while (!ByteOperations.KeyToByte(Console.ReadKey().KeyChar, ref y));
            } while (!board.Write(new Position(x, y), player.symbol));
            Console.Clear();
        }
    }
}