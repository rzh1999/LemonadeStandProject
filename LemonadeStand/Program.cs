using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display Welcome and Rules
            //Determine Game mode, Single player, MultiPlayer, or Human VS Robot
            //Set players up names, default info etc
            //Prompt user to select number of days to play 7, 14
            //Begin to set up game
            //Set and display intitial values to user 
            //Prompt if player wants to create a recipie, if not display and use a default
            //Display Shopping menu
            //Prompt user to buy goods from shopping menu
            //Display weaather and financial info available funds, cost of lemoneade per cup and list of starting ingredients
            //Play game this is where the program takes over and decides how many cups were sold
            // Create customers with % to buy and max value he is willing to pay
            //End of day: display profit or loss for that day and profit or loss for cumaltive days
            Game game = new Game();
            game.RunGame();
            Console.ReadLine();
        }
    }
}
