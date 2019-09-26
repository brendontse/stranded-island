using System;
using System.Collections.Generic;

namespace Adventure
{
    public class Program
    {
        public static void Main()
        {
            //  List<Game> itemList = new List<Game>(0);

            Console.WriteLine("--------------------------------\nGAME RULES\nGet off the island to win the game.\nHOW TO PLAY: you will be prompted for an action. You can use an item at any prompt, but to progress need to make the right decisions.\nHOW TO USE ITEMS: you will start the game with a given amount of items that you can use. There are three types of consumables: meals, snacks and water bottles. When prompted for actions, as long as you have items in inventory, you can type 'eat meal', 'eat snack' or 'drink water'.\nType 'reset' at any time to restart game.\n--------------------------------");

            Console.WriteLine("Enter a player name:");
            string name = Console.ReadLine();
            Console.WriteLine("Your player name is " + name);

            Game game = new Game(name, 100, 100, 100, 2, 2, 2, false);
            
            Level level = new Level();

            Level.StartLevelOne(game);
        }
    }
}
