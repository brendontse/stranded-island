using System;


namespace Adventure
{
    class Game
    {
    private string _playerName;
    private int _food;
    private int _water;
    private int _stamina;

    public Game(string playerName, int food, int water, int stamina)
    {
        _playerName = playerName;
        _food = food;
        _water = water;
        _stamina = stamina;
    }


    public string GetPlayerName()
    {
        return _playerName;
    }

    public int GetFood()
    {
        return _food;
    }

    public int GetWater()
    {
        return _water;
    }

    public int GetStamina()
    {
        return _stamina;
    }

    public void SetMeal()
    {
        _food += 5;
    }

    public void SetSnack()
    {
        _food += 3;
    }

    public void SetWater()
    {
        _water += 3;
    }

    public void SetStamina()
    {
        _stamina += 2;
    }


    }






     

    
}