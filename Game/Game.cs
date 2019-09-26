using System;


namespace Adventure
{
    class Game
    {
    private string _playerName;
    private int _foodLevel;
    private int _waterLevel;
    private int _stamina;
    private int _meal;
    private int _snack;
    private int _bottle;

    public Game(string playerName, int foodLevel, int waterLevel, int stamina, int meal, int snack, int bottle)
    {
        _playerName = playerName;
        _foodLevel = foodLevel;
        _waterLevel = waterLevel;
        _stamina = stamina;
        _meal = meal;
        _snack = snack;
        _bottle = bottle;
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
    
    public void Set

    }






     

    
}