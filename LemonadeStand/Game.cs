using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {

        public int gameMode;
        public Player player;
        public List<Day> days;
        public int currentDay;
        List<Player> players;
        public int numberOfDaysToPlay;

        public Game()
        {
            players = new List<Player>();
            player = new Player();
            players.Add(player);
        }

        public void DisplayRules()
        {
            Console.WriteLine($"Welcome to the lemonade stand game!");
            Console.WriteLine($"In this game we will see how good of a lemonade stand tycoon you are!");
            Console.WriteLine($"To play choose who will be playing, purchase goods, sell your lemonade its that simple.");
            Console.WriteLine($"You may even want to create your own recipie and see what happens!!!");
            Console.WriteLine();
            
        }

        public void SetGameMode()
        {
            Console.WriteLine($"Enter Game mode:");
            Console.WriteLine($"1. Single Player");
            Console.WriteLine($"2. Multi-Player");
            Console.WriteLine($"3. Player vs Computer");
            string userInput = Console.ReadLine();

            bool result;
            int choice;
            result = int.TryParse(userInput, out choice);
            while (choice < 1 || choice > 3)
            {
                Console.WriteLine($"Please enter a valid choice");
                userInput = Console.ReadLine();
                result = int.TryParse(userInput, out choice);
            }
            gameMode = choice;
        }

        public void CreatePlayer()
        {
            //Player player = new Player();
            switch (gameMode)
            {
                case 1:
                    //Player player = new Player();
                    Console.WriteLine($"Enter a players name:");
                    player.name = Console.ReadLine();
                    player.name = ValidatePlayerName(player.name);
                    break;
                case 2:
                    Console.WriteLine($"Enter number of players:");
                    string userInput = Console.ReadLine();
                    bool result;
                    int choice;
                    result = int.TryParse(userInput, out choice);
                    while (!result)
                    {
                        Console.WriteLine($"Please enter a valid choice");
                        userInput = Console.ReadLine();
                        result = int.TryParse(userInput, out choice);
                    }
                    for (int i = 0; i < choice; i++)
                    {
                        Player newPlayer = new Player();
                        Console.WriteLine($"Enter a players name:");
                        newPlayer.name = Console.ReadLine();
                        newPlayer.name = ValidatePlayerName(newPlayer.name);
                        players.Add(newPlayer);
                    }
                    break;
                case 3:
                    Player compPlayer = new Player();
                    compPlayer.name = "Computer";
                    players.Add(compPlayer);
                    break;
                default:
                    break;
            }
        }

        
        public string ValidatePlayerName(string playerName)
        {
            while (String.IsNullOrEmpty(playerName))
            {
                Console.WriteLine($"Please enter a valid player name:");
                playerName = Console.ReadLine();
            }
            return playerName;
        }

        public void SetNumberOfDaysToPlay()
        {
            Console.WriteLine($"How many days do you want to play? Must be 7 or more days!");
            string userInput = Console.ReadLine();

            bool result;
            int choice;
            result = int.TryParse(userInput, out choice);
            while (choice < 7)
            {
                Console.WriteLine($"Please enter a valid choice");
                userInput = Console.ReadLine();
                result = int.TryParse(userInput, out choice);
            }
            numberOfDaysToPlay = int.Parse(userInput);
        }

        public void DisplayInfoForEachPlayer(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            foreach(Player person in players)
            {
                Console.WriteLine($"Information for player {person.name}");
                Console.WriteLine($"Your wallet contains: {person.wallet.money.ToString("C", CultureInfo.CurrentCulture)}");
                Console.WriteLine();
                Console.WriteLine($" {person.name} your inventory contains the following:");
                Console.WriteLine($"Lemons: {player.inventory.lemons.Count()}");
                Console.WriteLine($"IceCubes: {player.inventory.iceCubes.Count()}");
                Console.WriteLine($"Cups: {player.inventory.cups.Count()}");
                Console.WriteLine($"Sugar Cubes: {player.inventory.lemons.Count()}");
            }
            Console.WriteLine("------------------------------------------");
        }
        public void RunGame()
        {
            DisplayRules();
            SetGameMode();
            CreatePlayer();
            SetNumberOfDaysToPlay();
            DisplayInfoForEachPlayer(players);
           
        }
    }
}
