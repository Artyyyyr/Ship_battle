namespace final_work;

public class Fight
{
    public void fight(PlayerDTO player1, PlayerDTO player2, Display game)
    {
        game.DisplayGame(player1);
        Console.WriteLine("Opponent's ships: 1x1 = {0}, 2x1 = {1}, 3x1 = {2}, 4x1 = {3}", player2.num_ship1, player2.num_ship2, player2.num_ship3, player2.num_ship4);
        Console.WriteLine("My ships: 1x1 = {0}, 2x1 = {1}, 3x1 = {2}, 4x1 = {3}", player1.num_ship1, player1.num_ship2, player1.num_ship3, player1.num_ship4);
        Console.Write("Point to shoot: ");
        Point point = new Point();
        string point_string = Console.ReadLine();
        try
        {
            if (Convert.ToInt32(point_string[0]) - 97 < 10 & Convert.ToInt32(point_string[0]) - 97 >= 0)
            {
                point.x = Convert.ToInt32(point_string[0]) - 97;
            }
            else
            {
                fight(player1, player2, game);
                return;
            }
        }
        catch (IndexOutOfRangeException)
        {
            fight(player1, player2, game);
            return;
        }

        try
        {
            if (Convert.ToInt32(point_string.Remove(0, 1)) - 1 >= 0 &
                Convert.ToInt32(point_string.Remove(0, 1)) - 1 < 10)
            {
                point.y = Convert.ToInt32(point_string.Remove(0, 1)) - 1;
            }
            else
            {
                fight(player1, player2, game);
                return;
            }
        }
        catch (FormatException)
        {
            fight(player1, player2, game);
            return;
        }
        catch (IndexOutOfRangeException)
        {
            fight(player1, player2, game);
            return;
        }

        if (player2.my_board[point.y, point.x] == 1)
        {
            player1.opponent_board[point.y, point.x] = 2;
            player2.my_board[point.y, point.x] = 2;
            bool up1_destroyed, up2_destroyed, up3_destroyed;
            bool down1_destroyed, down2_destroyed, down3_destroyed;
            bool right1_destroyed, right2_destroyed, right3_destroyed;
            bool left1_destroyed, left2_destroyed, left3_destroyed;

            bool up1_ship, up2_ship, up3_ship;
            bool down1_ship, down2_ship, down3_ship;
            bool right1_ship, right2_ship, right3_ship;
            bool left1_ship, left2_ship, left3_ship;

            try
            {
                up1_destroyed = player2.my_board[point.y - 1, point.x] == 2;
            }
            catch (IndexOutOfRangeException)
            {
                up1_destroyed = false;
            }

            try
            {
                up2_destroyed = player2.my_board[point.y - 2, point.x] == 2;
            }
            catch (IndexOutOfRangeException)
            {
                up2_destroyed = false;
            }

            try
            {
                up3_destroyed = player2.my_board[point.y - 3, point.x] == 2;
            }
            catch (IndexOutOfRangeException)
            {
                up3_destroyed = false;
            }

            try
            {
                down1_destroyed = player2.my_board[point.y + 1, point.x] == 2;
            }
            catch (IndexOutOfRangeException)
            {
                down1_destroyed = false;
            }

            try
            {
                down2_destroyed = player2.my_board[point.y + 2, point.x] == 2;
            }
            catch (IndexOutOfRangeException)
            {
                down2_destroyed = false;
            }

            try
            {
                down3_destroyed = player2.my_board[point.y + 3, point.x] == 2;
            }
            catch (IndexOutOfRangeException)
            {
                down3_destroyed = false;
            }

            try
            {
                right1_destroyed = player2.my_board[point.y, point.x + 1] == 2;
            }
            catch (IndexOutOfRangeException)
            {
                right1_destroyed = false;
            }

            try
            {
                right2_destroyed = player2.my_board[point.y, point.x + 2] == 2;
            }
            catch (IndexOutOfRangeException)
            {
                right2_destroyed = false;
            }

            try
            {
                right3_destroyed = player2.my_board[point.y, point.x + 3] == 2;
            }
            catch (IndexOutOfRangeException)
            {
                right3_destroyed = false;
            }

            try
            {
                left1_destroyed = player2.my_board[point.y, point.x - 1] == 2;
            }
            catch (IndexOutOfRangeException)
            {
                left1_destroyed = false;
            }

            try
            {
                left2_destroyed = player2.my_board[point.y, point.x - 2] == 2;
            }
            catch (IndexOutOfRangeException)
            {
                left2_destroyed = false;
            }

            try
            {
                left3_destroyed = player2.my_board[point.y, point.x - 3] == 2;
            }
            catch (IndexOutOfRangeException)
            {
                left3_destroyed = false;
            }

            try
            {
                up1_ship = player2.my_board[point.y - 1, point.x] == 1;
            }
            catch (IndexOutOfRangeException)
            {
                up1_ship = false;
            }

            try
            {
                up2_ship = player2.my_board[point.y - 2, point.x] == 1;
            }
            catch (IndexOutOfRangeException)
            {
                up2_ship = false;
            }

            try
            {
                up3_ship = player2.my_board[point.y - 3, point.x] == 1;
            }
            catch (IndexOutOfRangeException)
            {
                up3_ship = false;
            }

            try
            {
                down1_ship = player2.my_board[point.y + 1, point.x] == 1;
            }
            catch (IndexOutOfRangeException)
            {
                down1_ship = false;
            }

            try
            {
                down2_ship = player2.my_board[point.y + 2, point.x] == 1;
            }
            catch (IndexOutOfRangeException)
            {
                down2_ship = false;
            }

            try
            {
                down3_ship = player2.my_board[point.y + 3, point.x] == 1;
            }
            catch (IndexOutOfRangeException)
            {
                down3_ship = false;
            }

            try
            {
                right1_ship = player2.my_board[point.y, point.x + 1] == 1;
            }
            catch (IndexOutOfRangeException)
            {
                right1_ship = false;
            }

            try
            {
                right2_ship = player2.my_board[point.y, point.x + 2] == 1;
            }
            catch (IndexOutOfRangeException)
            {
                right2_ship = false;
            }

            try
            {
                right3_ship = player2.my_board[point.y, point.x + 3] == 1;
            }
            catch (IndexOutOfRangeException)
            {
                right3_ship = false;
            }

            try
            {
                left1_ship = player2.my_board[point.y, point.x - 1] == 1;
            }
            catch (IndexOutOfRangeException)
            {
                left1_ship = false;
            }

            try
            {
                left2_ship = player2.my_board[point.y, point.x - 2] == 1;
            }
            catch (IndexOutOfRangeException)
            {
                left2_ship = false;
            }

            try
            {
                left3_ship = player2.my_board[point.y, point.x - 3] == 1;
            }
            catch (IndexOutOfRangeException)
            {
                left3_ship = false;
            }

            if (!up1_destroyed & !up1_ship &
                !right1_destroyed & !right1_ship &
                !down1_destroyed & !down1_ship &
                !left1_destroyed & !left1_ship)
            {
                circle(player1, player2, point);
                player2.num_ship1 = player2.num_ship1 - 1;
            }
            else if (up1_destroyed &
                     !up2_destroyed & !up2_ship &
                     !down1_destroyed & !down1_ship)
            {
                Point point1 = new Point(point.x, point.y - 1);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                player2.num_ship2 = player2.num_ship2 - 1;
            }
            else if (down1_destroyed &
                     !down2_destroyed & !down2_ship &
                     !up1_destroyed & !up1_ship)
            {
                Point point1 = new Point(point.x, point.y + 1);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                player2.num_ship2 = player2.num_ship2 - 1;
            }
            else if (right1_destroyed &
                     !right2_destroyed & !right2_ship &
                     !left1_destroyed & !left1_ship)
            {
                Point point1 = new Point(point.x + 1, point.y);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                player2.num_ship2 = player2.num_ship2 - 1;
            }
            else if (left1_destroyed &
                     !left2_destroyed & !left2_ship &
                     !right1_destroyed & !right1_ship)
            {
                Point point1 = new Point(point.x - 1, point.y);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                player2.num_ship2 = player2.num_ship2 - 1;
            }
            else if (down1_destroyed &
                     down2_destroyed &
                     !down3_destroyed & !down3_ship &
                     !up1_destroyed & !up1_ship)
            {
                Point point1 = new Point(point.x, point.y + 1);
                Point point2 = new Point(point.x, point.y + 2);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                circle(player1, player2, point2);
                player2.num_ship3 = player2.num_ship3 - 1;
            }
            else if (down1_destroyed &
                     up1_destroyed &
                     !down2_destroyed & !down2_ship &
                     !up2_destroyed & !up2_ship)
            {
                Point point1 = new Point(point.x, point.y + 1);
                Point point2 = new Point(point.x, point.y - 1);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                circle(player1, player2, point2);
                player2.num_ship3 = player2.num_ship3 - 1;
            }
            else if (up1_destroyed &
                     up2_destroyed &
                     !up3_destroyed & !up3_ship &
                     !down1_destroyed & !down1_ship)
            {
                Point point1 = new Point(point.x, point.y - 1);
                Point point2 = new Point(point.x, point.y - 2);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                circle(player1, player2, point2);
                player2.num_ship3 = player2.num_ship3 - 1;
            }
            else if (right1_destroyed &
                     right2_destroyed &
                     !right3_destroyed & !right3_ship &
                     !left1_destroyed & !left1_ship)
            {
                Point point1 = new Point(point.x + 1, point.y);
                Point point2 = new Point(point.x + 2, point.y);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                circle(player1, player2, point2);
                player2.num_ship3 = player2.num_ship3 - 1;
            }
            else if (right1_destroyed &
                     left1_destroyed &
                     !right2_destroyed & !right2_ship &
                     !left2_destroyed & !left2_ship)
            {
                Point point1 = new Point(point.x + 1, point.y);
                Point point2 = new Point(point.x - 1, point.y);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                circle(player1, player2, point2);
                player2.num_ship3 = player2.num_ship3 - 1;
            }
            else if (left1_destroyed &
                     left2_destroyed &
                     !left3_destroyed & !left3_ship &
                     !right1_destroyed & !right1_ship)
            {
                Point point1 = new Point(point.x - 1, point.y);
                Point point2 = new Point(point.x - 2, point.y);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                circle(player1, player2, point2);
                player2.num_ship3 = player2.num_ship3 - 1;
            }
            else if (down1_destroyed &
                     down2_destroyed &
                     down3_destroyed)
            {
                Point point1 = new Point(point.x, point.y + 1);
                Point point2 = new Point(point.x, point.y + 2);
                Point point3 = new Point(point.x, point.y + 3);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                circle(player1, player2, point2);
                circle(player1, player2, point3);
                player2.num_ship4 = player2.num_ship4 - 1;
            }
            else if (down1_destroyed &
                     down2_destroyed &
                     up1_destroyed)
            {
                Point point1 = new Point(point.x, point.y + 1);
                Point point2 = new Point(point.x, point.y + 2);
                Point point3 = new Point(point.x, point.y - 1);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                circle(player1, player2, point2);
                circle(player1, player2, point3);
                player2.num_ship4 = player2.num_ship4 - 1;
            }
            else if (up1_destroyed &
                     up2_destroyed &
                     down1_destroyed)
            {
                Point point1 = new Point(point.x, point.y - 1);
                Point point2 = new Point(point.x, point.y - 2);
                Point point3 = new Point(point.x, point.y + 1);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                circle(player1, player2, point2);
                circle(player1, player2, point3);
                player2.num_ship4 = player2.num_ship4 - 1;
            }
            else if (up1_destroyed &
                     up2_destroyed &
                     up3_destroyed)
            {
                Point point1 = new Point(point.x, point.y - 1);
                Point point2 = new Point(point.x, point.y - 2);
                Point point3 = new Point(point.x, point.y - 3);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                circle(player1, player2, point2);
                circle(player1, player2, point3);
                player2.num_ship4 = player2.num_ship4 - 1;
            }
            else if (right1_destroyed &
                     right2_destroyed &
                     right3_destroyed)
            {
                Point point1 = new Point(point.x + 1, point.y);
                Point point2 = new Point(point.x + 2, point.y);
                Point point3 = new Point(point.x + 3, point.y);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                circle(player1, player2, point2);
                circle(player1, player2, point3);
                player2.num_ship4 = player2.num_ship4 - 1;
            }
            else if (right1_destroyed &
                     right2_destroyed &
                     left1_destroyed)
            {
                Point point1 = new Point(point.x + 1, point.y);
                Point point2 = new Point(point.x + 2, point.y);
                Point point3 = new Point(point.x - 1, point.y);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                circle(player1, player2, point2);
                circle(player1, player2, point3);
                player2.num_ship4 = player2.num_ship4 - 1;
            }
            else if (left1_destroyed &
                     left2_destroyed &
                     right1_destroyed)
            {
                Point point1 = new Point(point.x - 1, point.y);
                Point point2 = new Point(point.x - 2, point.y);
                Point point3 = new Point(point.x + 1, point.y);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                circle(player1, player2, point2);
                circle(player1, player2, point3);
                player2.num_ship4 = player2.num_ship4 - 1;
            }
            else if (left1_destroyed &
                     left2_destroyed &
                     left3_destroyed)
            {
                Point point1 = new Point(point.x - 1, point.y);
                Point point2 = new Point(point.x - 2, point.y);
                Point point3 = new Point(point.x - 3, point.y);
                circle(player1, player2, point);
                circle(player1, player2, point1);
                circle(player1, player2, point2);
                circle(player1, player2, point3);
                player2.num_ship4 = player2.num_ship4 - 1;
            }
            fight(player1, player2, game);
        }
        else if (player2.my_board[point.y, point.x] == 0)
        {
            player1.opponent_board[point.y, point.x] = 3;
            player2.my_board[point.y, point.x] = 3;
        }
    }

    void circle(PlayerDTO player1, PlayerDTO player2, Point point)
    {
        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                try
                {
                    if (player2.my_board[point.y + j, point.x + i] != 2)
                    {
                        player1.opponent_board[point.y + j, point.x + i] = 3;
                        player2.my_board[point.y + j, point.x + i] = 3;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                }
            }
        }
    }
}