using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {

        public int GameMode;
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
            GameMode = choice;
        }

        public void RunGame()
        {
            DisplayRules();
            SetGameMode();
        }
    }
}
