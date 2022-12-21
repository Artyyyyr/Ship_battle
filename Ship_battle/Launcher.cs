namespace final_work;

public class Launcher
{
    static void Main()
    {
        Console.Clear();
// . - empty, S - your ship, D - destroyed, x - miss, 0 - choice_place, 0 - choice_remove
// 0 - empty, 1 - your ship, 2 - destroyed, 3 - miss, 4 - choice_place, 5 - choice_remove

        int board_size = 10;
        PlayerDTO player1 = new PlayerDTO();
        PlayerDTO player2 = new PlayerDTO();
        Display display = new Display();
        List<int> story = new List<int>();

        StartGame(player1, player2, display, story);
    }
    static void StartGame(PlayerDTO player1, PlayerDTO player2, Display display, List<int> story)
    {
        display.DisplayMenu(player1, player2);
        int choice = -1;
        try
        {
            choice = Convert.ToInt32(Console.ReadLine());
        }
        catch(FormatException)
        {
            
        }

        if (choice == 1)
        {
            Console.Clear();
            Console.Write("Player1 name: ");
            player1.name = Console.ReadLine();
            Console.Write("Player2 name: ");
            player2.name = Console.ReadLine();
            StartGame(player1, player2, display, story);
        }
        else if (choice == 2)
        {
            Console.Clear();
            Console.WriteLine("List of games");
            for (int i = 0; i < story.Count; i++)
            {
                if (story[i] == 1)
                {
                    Console.WriteLine("Game {0} {1} won", i, player1.name);
                }
                else if (story[i] == 2)
                {
                    Console.WriteLine("Game {0} {1} won", i, player2.name);
                }
                else
                {
                    Console.WriteLine("Game {0} draw", i);
                }
                
            }

            Console.WriteLine("Press something to return");
            Console.ReadKey();
            StartGame(player1, player2, display, story);
            return;
        }
        else if (choice == 3)
        {
            Place place = new Place();
            place.place_ship(player1, display);
            place.place_ship(player2, display);
            Fight fight = new Fight();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("{0} press something to start", player1.name);
                Console.ReadKey();
                fight.fight(player1, player2, display);
                Console.Clear();
                Console.WriteLine("{0} press something to start", player2.name);
                Console.ReadKey();
                fight.fight(player2, player1, display);
                if (player1.num_ship1 == 0 & player1.num_ship2 == 0 & player1.num_ship3 == 0 & player1.num_ship4 == 0 &
                    player2.num_ship1 == 0 & player2.num_ship2 == 0 & player2.num_ship3 == 0 & player2.num_ship4 == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Draw");
                    story.Add(0);
                    player1.clear();
                    player2.clear();
                    Console.WriteLine("Press something to continue");
                    Console.ReadKey();
                    break;
                }
                else if (player1.num_ship1 == 0 & player1.num_ship2 == 0 & player1.num_ship3 == 0 & player1.num_ship4 == 0)
                {
                    Console.Clear();
                    Console.WriteLine("{0} won!", player2.name);
                    story.Add(2);
                    player1.clear();
                    player2.clear();
                    Console.WriteLine("Press something to continue");
                    Console.ReadKey();
                    break;
                }
                else if (player2.num_ship1 == 0 & player2.num_ship2 == 0 & player2.num_ship3 == 0 & player2.num_ship4 == 0)
                {
                    Console.Clear();
                    Console.WriteLine("{0} won!", player1.name);
                    story.Add(1);
                    player1.clear();
                    player2.clear();
                    Console.WriteLine("Press something to continue");
                    Console.ReadKey();
                    break;
                }
            }
            StartGame(player1, player2, display, story);
        }
        else
        {
            StartGame(player1, player2, display, story);
        }
    }
}