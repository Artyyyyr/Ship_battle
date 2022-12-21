namespace final_work;

public class PlayerDTO
{
    public int[,] my_board =
    {
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0}, 
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0}
    };
    
    public int[,] opponent_board =
    {
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0}, 
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
        {0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0}
    };

    public string name = "Player";
    public int num_ship4 = 0;
    public int num_ship3 = 0;
    public int num_ship2 = 0;
    public int num_ship1 = 0;

    public void clear()
    {
        num_ship4 = 0;
        num_ship3 = 0;
        num_ship2 = 0;
        num_ship1 = 0;

        int board_size = 10;
        for (int i = 0; i < board_size; i++)
        {
            for (int j = 0; j < board_size; j++)
            {
                my_board[i, j] = 0;
                opponent_board[i, j] = 0;
            }
        }
    }
}