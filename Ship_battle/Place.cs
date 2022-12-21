namespace final_work;
public class Point
{
    public int x;
    public int y;

    public Point(int x = -1, int y = -1)
    {
        this.x = x;
        this.y = y;
    }
    
}

public class Place
{
    public void place_ship(PlayerDTO player, Display game)
    {
        game.DisplayPreGame(player);
        if (player.num_ship1 == 4 & player.num_ship2 == 3 & player.num_ship3 == 2 & player.num_ship4 == 1)
        {
            Console.WriteLine("You placed all ships\nDo you want to end?\ny - yes, n - no\n");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                return;
            }
            else
            {
                Console.Clear();
                game.DisplayPreGame(player);
            }
        }
        Point point1 = new Point();
        Point point2 = new Point();
        Console.WriteLine("Ships: 1x1 = {0}, 2x1 = {1}, 3x1 = {2}, 4x1 = {3}", 4 - player.num_ship1, 3 - player.num_ship2, 2 - player.num_ship3, 1 - player.num_ship4);
        Console.Write("Point 1: ");
        string point1_string = Console.ReadLine();
        try
        {
            if (Convert.ToInt32(point1_string[0]) - 97 < 10 & Convert.ToInt32(point1_string[0]) - 97 >= 0)
            {
                point1.x = Convert.ToInt32(point1_string[0]) - 97;
            }
            else
            {
                game.DisplayPreGame(player);
                place_ship(player, game);
                return;
            }
        }
        catch (IndexOutOfRangeException)
        {
            game.DisplayPreGame(player);
            place_ship(player, game);
            return;
        }
        

        try
        {
            if (Convert.ToInt32(point1_string.Remove(0, 1)) - 1 >= 0 &
                Convert.ToInt32(point1_string.Remove(0, 1)) - 1 < 10)
            {
                point1.y = Convert.ToInt32(point1_string.Remove(0, 1)) - 1;
            }
            else
            {
                game.DisplayPreGame(player);
                place_ship(player, game);
                return;
            }
        }
        catch (FormatException)
        {
            game.DisplayPreGame(player);
            place_ship(player, game);
            return;
        }
        catch (IndexOutOfRangeException)
        {
            game.DisplayPreGame(player);
            place_ship(player, game);
            return;
        }

        if (player.my_board[point1.y, point1.x] != 1)
        {
            player.my_board[point1.y, point1.x] = 4;
        }
        else
        {
            player.my_board[point1.y, point1.x] = 5;
        }
        
        
        game.DisplayPreGame(player);
        Console.Write("Point 2: ");
        string point2_string = Console.ReadLine();
        try
        {
            if (Convert.ToInt32(point2_string[0]) - 97 < 10 & Convert.ToInt32(point2_string[0]) - 97 >= 0)
            {
                point2.x = Convert.ToInt32(point2_string[0]) - 97;
            }
            else
            {
                if (player.my_board[point1.y, point1.x] == 4)
                { 
                    player.my_board[point1.y, point1.x] = 0;
                }
                else if (player.my_board[point1.y, point1.x] == 5)
                {
                    player.my_board[point1.y, point1.x] = 1;
                }
                game.DisplayPreGame(player);
                
                place_ship(player, game);
                return;
            }
        }
        catch (IndexOutOfRangeException)
        {
            if (player.my_board[point1.y, point1.x] == 4)
            { 
                player.my_board[point1.y, point1.x] = 0;
            }
            else if (player.my_board[point1.y, point1.x] == 5)
            {
                player.my_board[point1.y, point1.x] = 1;
            }
            game.DisplayPreGame(player);
            place_ship(player, game);
            return;
        }
        
        try
        {
            if (Convert.ToInt32(point2_string.Remove(0, 1)) - 1 >= 0 &
                Convert.ToInt32(point2_string.Remove(0, 1)) - 1 < 10)
            {
                point2.y = Convert.ToInt32(point2_string.Remove(0, 1)) - 1;
            }
            else
            {
                if (player.my_board[point1.y, point1.x] == 4)
                { 
                    player.my_board[point1.y, point1.x] = 0;
                }
                else if (player.my_board[point1.y, point1.x] == 5)
                {
                    player.my_board[point1.y, point1.x] = 1;
                }
                game.DisplayPreGame(player);
                place_ship(player, game);
                return;
            }
        }
        catch (FormatException)
        {
            if (player.my_board[point1.y, point1.x] == 4)
            { 
                player.my_board[point1.y, point1.x] = 0;
            }
            else if (player.my_board[point1.y, point1.x] == 5)
            {
                player.my_board[point1.y, point1.x] = 1;
            }
            game.DisplayPreGame(player);
            place_ship(player, game);
            return;
        }
        catch (IndexOutOfRangeException)
        {
            if (player.my_board[point1.y, point1.x] == 4)
            { 
                player.my_board[point1.y, point1.x] = 0;
            }
            else if (player.my_board[point1.y, point1.x] == 5)
            {
                player.my_board[point1.y, point1.x] = 1;
            }
            game.DisplayPreGame(player);
            place_ship(player, game);
            return;
        }
        if (point1.x == point2.x & point1.y == point2.y)
        {
            if (check_point(point1, player) & player.my_board[point1.y, point1.x] == 5)
            {
                player.my_board[point1.y, point1.x] = 0;
                player.num_ship1 = player.num_ship1 - 1;
            }
            else if (check_point(point1, player) & player.num_ship1 < 4)
            {
                player.my_board[point1.y, point1.x] = 1;
                player.num_ship1 = player.num_ship1 + 1;
            }
            else
            {
                if (check_point(point1, player) & player.num_ship1 < 4)
                {
                    player.my_board[point1.y, point1.x] = 0;
                    player.num_ship1 = player.num_ship1 - 1;
                }
                else if (player.my_board[point1.y, point1.x] == 5)
                {
                    player.my_board[point1.y, point1.x] = 1;
                }
                else
                {
                    player.my_board[point1.y, point1.x] = 0;
                }
            }
        }
        else if (point1.x == point2.x)
        {
            if (Math.Abs(point1.y - point2.y) == 1)
            {
                if (check_point(point1, player) & check_point(point2, player))
                {
                    if (player.num_ship2 < 3)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                        player.my_board[point2.y, point2.x] = 1;
                        player.num_ship2 = player.num_ship2 + 1;
                    }
                    else if (player.my_board[point1.y, point1.x] == 5)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                    }
                    else
                    {
                        player.my_board[point1.y, point1.x] = 0;
                    }
                }
                else
                {
                    if (player.my_board[point1.y, point1.x] == 5 & player.my_board[point2.y, point2.x] == 1)
                    {
                        player.my_board[point1.y, point1.x] = 0;
                        player.my_board[point2.y, point2.x] = 0;
                        player.num_ship2 = player.num_ship2 - 1;

                            if (!check_point(point1, player) | !check_point(point2, player))
                        {
                            player.my_board[point1.y, point1.x] = 1;
                            player.my_board[point2.y, point2.x] = 1;
                            player.num_ship2 = player.num_ship2 + 1;
                        }
                    }
                    else if (player.my_board[point1.y, point1.x] == 5)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                    }
                    else
                    {
                        player.my_board[point1.y, point1.x] = 0;
                    }
                }
            }
            else if (Math.Abs(point1.y - point2.y) == 2)
            {
                Point middle = new Point((point1.x + point2.x)/2, (point1.y + point2.y)/2);
                if (check_point(point1, player) & check_point(point2, player) &  check_point(middle, player))
                {
                    if (player.num_ship3 < 2)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                        player.my_board[point2.y, point2.x] = 1;
                        player.my_board[middle.y, middle.x] = 1;
                        player.num_ship3 = player.num_ship3 + 1;
                    }
                    else if (player.my_board[point1.y, point1.x] == 5)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                    }
                    else
                    {
                        player.my_board[point1.y, point1.x] = 0;
                    }
                }
                else
                {
                    if (player.my_board[point1.y, point1.x] == 5 & player.my_board[point2.y, point2.x] == 1 & player.my_board[middle.y, middle.x] == 1)
                    {
                        player.my_board[point1.y, point1.x] = 0;
                        player.my_board[point2.y, point2.x] = 0;
                        player.my_board[middle.y, middle.x] = 0;
                        player.num_ship3 = player.num_ship3 - 1;
                        if (!check_point(point1, player) | !check_point(point2, player) | !check_point(middle, player))
                        {
                            player.my_board[point1.y, point1.x] = 1;
                            player.my_board[point2.y, point2.x] = 1;
                            player.my_board[middle.y, middle.x] = 1;
                            player.num_ship3 = player.num_ship3 + 1;
                        }
                    }
                    else if (player.my_board[point1.y, point1.x] == 5)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                    }
                    else
                    {
                        player.my_board[point1.y, point1.x] = 0;
                    }
                }
            }
            else if (Math.Abs(point1.y - point2.y) == 3)
            {
                Point middle1 = new Point(point1.x);
                Point middle2 = new Point(point1.x);
                if (point1.y > point2.y)
                {
                    middle1.y = point1.y - 1;
                    middle2.y = point1.y - 2;
                }
                else
                {
                    middle1.y = point2.y - 1;
                    middle2.y = point2.y - 2;
                }
                
                if (check_point(point1, player) & check_point(point2, player) & check_point(middle1, player) & check_point(middle2, player))
                {
                    if (player.num_ship4 < 1)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                        player.my_board[point2.y, point2.x] = 1;
                        player.my_board[middle1.y, middle1.x] = 1;
                        player.my_board[middle2.y, middle2.x] = 1;
                        player.num_ship4 = player.num_ship4 + 1;
                    }
                    else if (player.my_board[point1.y, point1.x] == 5)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                        player.num_ship4 = player.num_ship4 + 1;
                    }
                    else
                    {
                        player.my_board[point1.y, point1.x] = 0;
                    }
                }
                else
                {
                    if (player.my_board[point1.y, point1.x] == 5 & player.my_board[point2.y, point2.x] == 1 & player.my_board[middle1.y, middle1.x] == 1 & player.my_board[middle2.y, middle2.x] == 1)
                    {
                        player.my_board[point1.y, point1.x] = 0;
                        player.my_board[point2.y, point2.x] = 0;
                        player.my_board[middle1.y, middle1.x] = 0;
                        player.my_board[middle2.y, middle2.x] = 0;
                        player.num_ship4 = player.num_ship4 - 1;
                        if (!check_point(point1, player) | !check_point(point2, player) | !check_point(middle1, player) | !check_point(middle2, player))
                        {
                            player.my_board[point1.y, point1.x] = 1;
                            player.my_board[point2.y, point2.x] = 1;
                            player.my_board[middle1.y, middle1.x] = 1;
                            player.my_board[middle2.y, middle2.x] = 1;
                            player.num_ship4 = player.num_ship4 + 1;
                        }
                    }
                    else if (player.my_board[point1.y, point1.x] == 5)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                    }
                    else
                    {
                        player.my_board[point1.y, point1.x] = 0;
                    }
                }
            }
            else
            {
                if (player.my_board[point1.y, point1.x] == 5)
                {
                    player.my_board[point1.y, point1.x] = 1;
                }
                else
                {
                    player.my_board[point1.y, point1.x] = 0;
                }
            }
        }
        else if (point1.y == point2.y)
        {
            if (Math.Abs(point1.x - point2.x) == 1)
            {
                if (check_point(point1, player) & check_point(point2, player))
                {
                    if (player.num_ship2 < 3)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                        player.my_board[point2.y, point2.x] = 1;
                        player.num_ship2 = player.num_ship2 + 1;
                    }
                    else if (player.my_board[point1.y, point1.x] == 5)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                    }
                    else
                    {
                        player.my_board[point1.y, point1.x] = 0;
                    }
                }
                else
                {
                    if (player.my_board[point1.y, point1.x] == 5 & player.my_board[point2.y, point2.x] == 1)
                    {
                        player.my_board[point1.y, point1.x] = 0;
                        player.my_board[point2.y, point2.x] = 0;
                        player.num_ship2 = player.num_ship2 - 1;
                        if (!check_point(point1, player) | !check_point(point2, player))
                        {
                            player.my_board[point1.y, point1.x] = 1;
                            player.my_board[point2.y, point2.x] = 1;
                            player.num_ship2 = player.num_ship2 + 1;
                        }
                    }
                    else if (player.my_board[point1.y, point1.x] == 5)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                    }
                    else
                    {
                        player.my_board[point1.y, point1.x] = 0;
                    }
                }
            }
            else if (Math.Abs(point1.x - point2.x) == 2)
            {
                Point middle = new Point((point1.x + point2.x)/2, (point1.y + point2.y)/2);
                if (check_point(point1, player) & check_point(point2, player) &  check_point(middle, player))
                {
                    if (player.num_ship3 < 2)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                        player.my_board[point2.y, point2.x] = 1;
                        player.my_board[middle.y, middle.x] = 1;
                        player.num_ship3 = player.num_ship3 + 1;
                    }
                    else if (player.my_board[point1.y, point1.x] == 5)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                    }
                    else
                    {
                        player.my_board[point1.y, point1.x] = 0;
                    }
                }
                else
                {
                    if (player.my_board[point1.y, point1.x] == 5 & player.my_board[point2.y, point2.x] == 1 & player.my_board[middle.y, middle.x] == 1)
                    {
                        player.my_board[point1.y, point1.x] = 0;
                        player.my_board[point2.y, point2.x] = 0;
                        player.my_board[middle.y, middle.x] = 0;
                        player.num_ship3 = player.num_ship3 - 1;
                        if (!check_point(point1, player) | !check_point(point2, player) | !check_point(middle, player))
                        {
                            player.my_board[point1.y, point1.x] = 1;
                            player.my_board[point2.y, point2.x] = 1;
                            player.my_board[middle.y, middle.x] = 1;
                            player.num_ship3 = player.num_ship3 + 1;
                        }
                    }
                    else if (player.my_board[point1.y, point1.x] == 5)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                    }
                    else
                    {
                        player.my_board[point1.y, point1.x] = 0;
                    }
                }
            }
            else if (Math.Abs(point1.x - point2.x) == 3)
            {
                Point middle1 = new Point(-1, point1.y);
                Point middle2 = new Point(-1, point1.y);
                if (point1.x > point2.x)
                {
                    middle1.x = point1.x - 1;
                    middle2.x = point1.x - 2;
                }
                else
                {
                    middle1.x = point2.x - 1;
                    middle2.x = point2.x - 2;
                }
                
                if (check_point(point1, player) & check_point(point2, player) & check_point(middle1, player) & check_point(middle2, player))
                {
                    if (player.num_ship4 < 1)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                        player.my_board[point2.y, point2.x] = 1;
                        player.my_board[middle1.y, middle1.x] = 1;
                        player.my_board[middle2.y, middle2.x] = 1;
                        player.num_ship4 = player.num_ship4 + 1;
                    }
                    else if (player.my_board[point1.y, point1.x] == 5)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                    }
                    else
                    {
                        player.my_board[point1.y, point1.x] = 0;
                    }
                }
                else
                {
                    if (player.my_board[point1.y, point1.x] == 5 & player.my_board[point2.y, point2.x] == 1 & player.my_board[middle1.y, middle1.x] == 1 & player.my_board[middle2.y, middle2.x] == 1)
                    {
                        player.my_board[point1.y, point1.x] = 0;
                        player.my_board[point2.y, point2.x] = 0;
                        player.my_board[middle1.y, middle1.x] = 0;
                        player.my_board[middle2.y, middle2.x] = 0;
                        player.num_ship4 = player.num_ship4 - 1;
                        if (!check_point(point1, player) | !check_point(point2, player) | !check_point(middle1, player) | !check_point(middle2, player))
                        {
                            player.my_board[point1.y, point1.x] = 1;
                            player.my_board[point2.y, point2.x] = 1;
                            player.my_board[middle1.y, middle1.x] = 1;
                            player.my_board[middle2.y, middle2.x] = 1;
                            player.num_ship4 = player.num_ship4 + 1;
                        }
                    }
                    else if (player.my_board[point1.y, point1.x] == 5)
                    {
                        player.my_board[point1.y, point1.x] = 1;
                    }
                    else
                    {
                        player.my_board[point1.y, point1.x] = 0;
                    }
                }
            }
            else
            {
                if (player.my_board[point1.y, point1.x] == 5)
                {
                    player.my_board[point1.y, point1.x] = 1;
                }
                else
                {
                    player.my_board[point1.y, point1.x] = 0;
                }
            }
        }
        else
        {
            if (player.my_board[point1.y, point1.x] == 5)
            {
                player.my_board[point1.y, point1.x] = 1;
            }
            else
            {
                player.my_board[point1.y, point1.x] = 0;
            }
        }
        place_ship(player, game);
    }

    bool check_point(Point point, PlayerDTO player)
    {
        if (point.x - 1 >= 0 & point.y - 1 >= 0 & point.x + 1 < 10 & point.y + 1 < 10)
        {
            if (player.my_board[point.y + 1, point.x] == 1 | player.my_board[point.y + 1, point.x] == 5 |
                player.my_board[point.y + 1, point.x + 1] == 1 | player.my_board[point.y + 1, point.x + 1] == 5 |
                player.my_board[point.y, point.x + 1] == 1 | player.my_board[point.y, point.x + 1] == 5 |
                player.my_board[point.y - 1, point.x + 1] == 1 | player.my_board[point.y - 1, point.x + 1] == 5 |
                player.my_board[point.y - 1, point.x] == 1 | player.my_board[point.y - 1, point.x] == 5 |
                player.my_board[point.y - 1, point.x - 1] == 1 | player.my_board[point.y - 1, point.x - 1] == 5 |
                player.my_board[point.y, point.x - 1] == 1 | player.my_board[point.y, point.x - 1] == 5 |
                player.my_board[point.y + 1, point.x - 1] == 1 | player.my_board[point.y + 1, point.x - 1] == 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else if (point.x - 1 < 0 & point.y - 1 < 0 & point.x + 1 < 10 & point.y + 1 < 10)
        {
            if (player.my_board[point.y + 1, point.x] == 1 | player.my_board[point.y + 1, point.x] == 5 |
                player.my_board[point.y + 1, point.x + 1] == 1 | player.my_board[point.y + 1, point.x + 1] == 5 |
                player.my_board[point.y, point.x + 1] == 1 | player.my_board[point.y, point.x + 1] == 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else if (point.x - 1 >= 0 & point.y - 1 < 0 & point.x + 1 < 10 & point.y + 1 < 10)
        {
            if (player.my_board[point.y + 1, point.x] == 1 | player.my_board[point.y + 1, point.x] == 5 |
                player.my_board[point.y + 1, point.x + 1] == 1 | player.my_board[point.y + 1, point.x + 1] == 5 |
                player.my_board[point.y, point.x + 1] == 1 | player.my_board[point.y, point.x + 1] == 5 |
                player.my_board[point.y, point.x - 1] == 1 | player.my_board[point.y, point.x - 1] == 5 |
                player.my_board[point.y + 1, point.x - 1] == 1 | player.my_board[point.y + 1, point.x - 1] == 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else if (point.x - 1 >= 0 & point.y - 1 < 0 & point.x + 1 >= 10 & point.y + 1 < 10)
        {
            if (player.my_board[point.y + 1, point.x] == 1 | player.my_board[point.y + 1, point.x] == 5 |
                player.my_board[point.y, point.x - 1] == 1 | player.my_board[point.y, point.x - 1] == 5 |
                player.my_board[point.y + 1, point.x - 1] == 1 | player.my_board[point.y + 1, point.x - 1] == 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else if (point.x - 1 >= 0 & point.y - 1 >= 0 & point.x + 1 >= 10 & point.y + 1 < 10)
        {
            if (player.my_board[point.y + 1, point.x] == 1 | player.my_board[point.y + 1, point.x] == 5 |
                player.my_board[point.y - 1, point.x] == 1 | player.my_board[point.y - 1, point.x] == 5 |
                player.my_board[point.y - 1, point.x - 1] == 1 | player.my_board[point.y - 1, point.x - 1] == 5 |
                player.my_board[point.y, point.x - 1] == 1 | player.my_board[point.y, point.x - 1] == 5 |
                player.my_board[point.y + 1, point.x - 1] == 1 | player.my_board[point.y + 1, point.x - 1] == 5)
            {
                return false;
            }
            else
            {
                return true;
            }                                                                                                   
        }                                                                                                       
        else if (point.x - 1 >= 0 & point.y - 1 >= 0 & point.x + 1 >= 10 & point.y + 1 >= 10)
        {
            if (player.my_board[point.y - 1, point.x] == 1 | player.my_board[point.y - 1, point.x] == 5 |
                player.my_board[point.y - 1, point.x - 1] == 1 | player.my_board[point.y - 1, point.x - 1] == 5 |
                player.my_board[point.y, point.x - 1] == 1 | player.my_board[point.y, point.x - 1] == 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else if (point.x - 1 >= 0 & point.y - 1 >= 0 & point.x + 1 < 10 & point.y + 1 >= 10)
        {
            if (player.my_board[point.y, point.x + 1] == 1 | player.my_board[point.y, point.x + 1] == 5 |
                player.my_board[point.y - 1, point.x + 1] == 1 | player.my_board[point.y - 1, point.x + 1] == 5 |
                player.my_board[point.y - 1, point.x] == 1 | player.my_board[point.y - 1, point.x] == 5 |
                player.my_board[point.y - 1, point.x - 1] == 1 | player.my_board[point.y - 1, point.x - 1] == 5 |
                player.my_board[point.y, point.x - 1] == 1 | player.my_board[point.y, point.x - 1] == 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else if (point.x - 1 < 0 & point.y - 1 >= 0 & point.x + 1 < 10 & point.y + 1 >= 10)
        {
            if (player.my_board[point.y, point.x + 1] == 1 | player.my_board[point.y, point.x + 1] == 5 |
                player.my_board[point.y - 1, point.x + 1] == 1 | player.my_board[point.y - 1, point.x + 1] == 5 |
                player.my_board[point.y - 1, point.x] == 1 | player.my_board[point.y - 1, point.x] == 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else if (point.x - 1 < 0 & point.y - 1 >= 0 & point.x + 1 < 10 & point.y + 1 < 10)
        {
            if (player.my_board[point.y + 1, point.x] == 1 | player.my_board[point.y + 1, point.x] == 5 |
                player.my_board[point.y + 1, point.x + 1] == 1 | player.my_board[point.y + 1, point.x + 1] == 5 |
                player.my_board[point.y, point.x + 1] == 1 | player.my_board[point.y, point.x + 1] == 5 |
                player.my_board[point.y - 1, point.x + 1] == 1 | player.my_board[point.y - 1, point.x + 1] == 5 |
                player.my_board[point.y - 1, point.x] == 1 | player.my_board[point.y - 1, point.x] == 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}