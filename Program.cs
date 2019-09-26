using System;
using.System.Collections.Generic;

namespace Adventure
{
    class Program
    {
        static void Main()
        {
         List<Game> itemList = new List<Game>(0);

         Game game = new Game("bot", 2, 2, 2);

         Console.WriteLine("You woke up on an island. You feel hungry and thirsty. What do you do?");
         string firstLevel = Console.ReadLine();

        if (firstLevel.ToUpper() == "FIND FOOD" || firstLevel.ToUpper() == "LOOK FOR FOOD" || firstLevel.ToUpper() == "SEARCH FOR FOOD") 
        {
           
        }
        else if (firstLevel.ToUpper() == "FIND WATER" || firstLevel.ToUpper() == "LOOK FOR WATER" || firstLevel.ToUpper() == "SEARCH FOR WATER")
        {

        }
        }
    }
}
