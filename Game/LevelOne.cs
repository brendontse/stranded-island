using System;

namespace Adventure
{
    class Level
    {
        public static void StartLevelOne(Game game)
        {
        if (game.SetPlayerDeadCheck() == true)
        {
            GameOver(game);
        }
        else
        {
            Console.WriteLine("You woke up on an island. You feel hungry and thirsty. What do you do?");
            string userInput = Console.ReadLine();

            if (userInput.ToUpper() == "STATUS")
            {
                game.GetStatus();
                StartLevelOne(game);

            }
            else if (userInput.ToUpper() == "EAT MEAL") 
            {
                game.GetEatMeal();
                StartLevelOne(game);
            }
            else if (userInput.ToUpper() == "EAT SNACK")
            {
                game.GetEatSnack();
                StartLevelOne(game);
            }
            else if (userInput.ToUpper() == "DRINK WATER")
            {
                game.GetDrinkWater();
                StartLevelOne(game);
            }
            else if (userInput.ToUpper() == "BUILD SHELTER" || userInput.ToUpper() == "FIND SHELTER" || userInput.ToUpper() == "CREATE SHELTER" || userInput.ToUpper() == "MAKE SHELTER" || userInput.ToUpper() == "SHELTER" || userInput.ToUpper() == "BUILD SHELTER") 
            {
                Console.WriteLine("--------------------------------------------------------\nYou found shelter! LV.1\n--------------------------------------------------------");
                game.SetTurnEnd();
                StartLevelTwo(game);
            }
            else
            {
                game.SetMakeMistake();
                StartLevelOne(game);
            }
        }
         

        }

        public static void StartLevelTwo(Game game)
        {
        Console.WriteLine("You woke up on an island. You feel hungry and thirsty. What do you do?");
        string userInput = Console.ReadLine();

            if (userInput.ToUpper() == "STATUS")
            {
                game.GetStatus();
                StartLevelTwo(game);
            }
            else if (userInput.ToUpper() == "EAT MEAL") 
            {
                game.GetEatMeal();
                StartLevelTwo(game);
            }
            else if (userInput.ToUpper() == "EAT SNACK")
            {
                game.GetEatSnack();
                StartLevelTwo(game);
            }
            else if (userInput.ToUpper() == "DRINK WATER")
            {
                game.GetDrinkWater();
                StartLevelTwo(game);
            }
            else if (userInput.ToUpper() == "BUILD SHELTER" || userInput.ToUpper() == "FIND SHELTER" || userInput.ToUpper() == "CREATE SHELTER" || userInput.ToUpper() == "MAKE SHELTER" || userInput.ToUpper() == "SHELTER" || userInput.ToUpper() == "BUILD SHELTER") 
            {
                game.SetTurnEnd();
                // game.newInventory();
                // game.SetRest();
                // LevelThree(game);
            }
            else
            {
                game.SetMakeMistake();
                StartLevelTwo(game);
            }
        }

        public static void GameOver(Game game)
        {
            Console.WriteLine("gg uninstall");
        }
    }
}