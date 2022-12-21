namespace final_work;
public class Display : IDisplay
{
    private int board_size = 10;
    public void DisplayGame(PlayerDTO player)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("\t      Your board                                   Opponent");
        Console.WriteLine(
            "///////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\      ///////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        Console.WriteLine("|    a  b  c  d  e  f  g  h  i  j    |      |    a  b  c  d  e  f  g  h  i  j    |");
        for (int i = 0; i < board_size; i++)
        {
            if (i == 9)
            {
                Console.Write("|{0}  ", i + 1);
            }
            else
            {
                Console.Write("| {0}  ", i + 1);
            }

            for (int j = 0; j < board_size; j++)
            {
                if (player.my_board[i, j] == 0)
                {
                    Console.Write(".  ");
                }
                else if (player.my_board[i, j] == 4)
                {
                    Console.Write("0  ");
                }
                else if (player.my_board[i, j] == 1)
                {
                    Console.Write("S  ");
                }
                else if (player.my_board[i, j] == 2)
                {
                    Console.Write("D  ");
                }
                else if (player.my_board[i, j] == 3)
                {
                    Console.Write("x  ");
                }
                else
                {
                    Console.Write("?  ");
                }

            }

            if (i == 9)
            {
                Console.Write("  |      | {0} ", i + 1);
            }
            else
            {
                Console.Write("  |      | {0}  ", i + 1);
            }

            for (int j = 0; j < board_size; j++)
            {
                if (player.opponent_board[i, j] == 0)
                {
                    Console.Write(".  ");
                }
                else if (player.opponent_board[i, j] == 1)
                {
                    Console.Write("S  ");
                }
                else if (player.opponent_board[i, j] == 2)
                {
                    Console.Write("D  ");
                }
                else if (player.opponent_board[i, j] == 3)
                {
                    Console.Write("x  ");
                }
                else if (player.opponent_board[i, j] == 4)
                {
                    Console.Write("0  ");
                }
                else
                {
                    Console.Write("?  ");
                }

            }

            Console.WriteLine("  |");
        }

        Console.WriteLine("|                                    |      |                                    |");
        Console.WriteLine("|##||##000000 | (MyB) |  000000##||##|      |##||##000000 | (EnB) |  000000##||##|");
    }

    public void DisplayMenu(PlayerDTO player1, PlayerDTO player2)
    {
        Console.Clear();
        Console.WriteLine("1 - change name, 2 - view stats, 3 - start game");
    }

    public void DisplayPreGame(PlayerDTO player)
    {
        Console.Clear();
        Console.WriteLine("                                      " + player.name);
        Console.WriteLine();
        Console.WriteLine("                      ///////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        Console.WriteLine("                      |    a  b  c  d  e  f  g  h  i  j    | ");
        for (int i = 0; i < board_size; i++)
        {
            if (i == 9)
            {
                Console.Write("                      |{0}  ", i + 1);
            }
            else
            {
                Console.Write("                      | {0}  ", i + 1);
            }

            for (int j = 0; j < board_size; j++)
            {
                if (player.my_board[i, j] == 0)
                {
                    Console.Write(".  ");
                }
                else if (player.my_board[i, j] == 1)
                {
                    Console.Write("S  ");
                }
                else if (player.my_board[i, j] == 2)
                {
                    Console.Write("D  ");
                }
                else if (player.my_board[i, j] == 3)
                {
                    Console.Write("x  ");
                }
                else if (player.my_board[i, j] == 4 | player.my_board[i, j] == 5)
                {
                    Console.Write("0  ");
                }
                else
                {
                    Console.Write("?  ");
                }
            }

            Console.Write("  |");
            Console.WriteLine();
        }

        Console.WriteLine("                      |                                    |");
        Console.WriteLine("                      |##||##000000 | (MyB) |  000000##||##|");
        Console.WriteLine();
    }
}
