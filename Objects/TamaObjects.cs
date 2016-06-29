using System;
using System.Collections.Generic;

namespace Tamagotchi.Objects
{
  public class Tama
  {
    private string _name;
    private int _hunger;
    private int _happiness;
    private int _tiredness;
    private int _cleanliness;
    private static Tama _currentTama = new Tama();
    private bool _isAlive;

    private int _condition;

    public Tama()
    {
      _name = "";
      _hunger = 0;
      _happiness = 50;
      _cleanliness = 100;
      _tiredness = 0;
      _condition = 100;
      _currentTama = this;
      _isAlive = true;
    }

    public static Tama CurrentTama()
    {
      return _currentTama;
    }


    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public int GetHunger()
    {
      return _hunger;
    }
    public void SetHunger(int newHunger)
    {
      _hunger = newHunger;
    }
    public int GetHappiness()
    {
      return _happiness;
    }
    public void SetHappiness(int newHappiness)
    {
      _happiness = newHappiness;
    }
    public int GetCleanliness()
    {
      return _cleanliness;
    }
    public void SetCleanliness(int newCleanliness)
    {
      _cleanliness = newCleanliness;
    }
    public int GetTiredness()
    {
      return _tiredness;
    }
    public void SetTiredness(int newTiredness)
    {
      _tiredness = newTiredness;
    }
    public int GetCondition()
    {
      return _condition;
    }
    public void SetCondition(int newCondition)
    {
      _condition = newCondition;
    }


    public void Sleep()
    {
      this._hunger += 40;
      this._tiredness -= 50;
      this._happiness -= 10;
      this._cleanliness -= 30;
    }
    public void Eat()
    {
      this._hunger -= 40;
      this._cleanliness -= 20;
      this._tiredness += 20;
    }
    public void Clean()
    {
      this._hunger += 20;
      this._happiness -= 10;
      this._cleanliness = 100;
      this._tiredness += 20;
    }
    public void Play()
    {
      this._hunger += 20;
      this._happiness += 30;
      this._cleanliness -= 30;
      this._tiredness += 40;
    }

    public void Death()
    {
      if (this._hunger >=100 || this._happiness <= 0 || this._cleanliness <= 0 || this._tiredness >= 100)
      {
        _isAlive = false;
      }
    }

  }
}
