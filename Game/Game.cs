using System;


namespace Adventure
{
    // class Level
    // {

    // }
    class Game
        {
        private string _playerName;
        private int _foodLevel;
        private int _waterLevel;
        private int _stamina;
        private int _meal;
        private int _snack;
        private int _bottle;
        private bool _playerDead;

        public Game(string playerName, int foodLevel, int waterLevel, int stamina, int meal, int snack, int bottle, bool playerDead)
        {
            _playerName = playerName;
            _foodLevel = foodLevel;
            _waterLevel = waterLevel;
            _stamina = stamina;
            _meal = meal;
            _snack = snack;
            _bottle = bottle;
            _playerDead = playerDead;
        }


        public string GetPlayerName()
        {
            return _playerName;
        }

        public int GetFoodLevel()
        {
            return _foodLevel;
        }

        public int GetWaterLevel()
        {
            return _waterLevel;
        }

        public int GetStamina()
        {
            return _stamina;
        }


        public int GetMeal()
        {
            return _meal;
        }

        public int GetSnack()
        {
            return _snack;
        }

        public int GetBottle()
        {
            return _bottle;
        }

        public bool SetPlayerDeadCheck()
        {
            if (_foodLevel < 1 || _waterLevel < 1 || _stamina < 1)
            {
                return _playerDead = true;        
            } 
            else
            {
                return false;
            }
        }
        public void SetEatMeal()
        {
            _foodLevel += 25;
            _meal -= 1;
        }

        public void SetEatSnack()
        {
            _foodLevel += 10;
            _snack -= 1;
        }

        public void SetDrinkWater()
        {
            _waterLevel += 15;
            _bottle -= 1;
        }

        public void SetStamina()
        {
            _stamina += 20;
        }

        public void SetTurnEnd()
        {
            _foodLevel -= 10;
            _waterLevel -= 15;
            _stamina -= 10;
            
        }
        
        public void GetStatus()
        {
            string food = GetFoodLevel().ToString();
            string water = GetWaterLevel().ToString();
            string stamina = GetStamina().ToString();
            string meal = GetMeal().ToString();
            string snack = GetSnack().ToString();
            string bottle = GetBottle().ToString();

            string status = "--------------------------------------------------------\nYour current food level is " + food + ", your water level is " + water + ", and your stamina is " + stamina + ".\nYou have " + meal + " meal(s) left, " + snack + " snack(s) left, and " + bottle + " bottle(s) of water left.\n--------------------------------------------------------";

            Console.WriteLine(status);
        }
        
        public void GetEatMeal()
        {
            int BottleInv = GetMeal();
            
            if (BottleInv <= 0)
            {
                Console.WriteLine("--------------------------------------------------------\nYou have no meals left in your inventory. You used up some of your food, water, and stamina.\n--------------------------------------------------------");
            }
            else if (BottleInv > 0)
            {
                Console.WriteLine("--------------------------------------------------------\nYou just ate a meal, must be stuffed.\n--------------------------------------------------------");
                SetEatMeal();
            }
            SetTurnEnd();
        }
        public void GetEatSnack()
        {
            int SnackInv = GetSnack();
            
            if (SnackInv <= 0)
            {
                Console.WriteLine("--------------------------------------------------------\nYou have no snacks left in your inventory. You used up some of your food, water, and stamina.\n--------------------------------------------------------");
            }
            else if (SnackInv > 0)
            {
                Console.WriteLine("--------------------------------------------------------\nYou just ate a snack, you feel a little better.\n--------------------------------------------------------");
                SetEatSnack();
            }
            SetTurnEnd();
        }

        public void GetDrinkWater()
        {
            int BottleInv = GetBottle();
            
            if (BottleInv <= 0)
            {
                Console.WriteLine("--------------------------------------------------------\nYou have no more water left in your inventory. You used up some of your food, water, and stamina.\n--------------------------------------------------------");
            }
            else if (BottleInv > 0)
            {
                Console.WriteLine("--------------------------------------------------------\nYou just ate a meal, must be stuffed.\n--------------------------------------------------------");
                SetEatMeal();
            }
            SetTurnEnd();
        }

        public void SetMakeMistake()
        {
            Console.WriteLine("--------------------------------------------------------\nYou made a wrong or unavailable decision. You used up some of your food, water, and stamina.\n--------------------------------------------------------");
            SetTurnEnd();
        }
    }

}