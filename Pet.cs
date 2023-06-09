﻿namespace Viritual_Pet_Simulator
{
    public class Pet
    {
        private string _name { get; set; }
        private string _favFood { get; set; }
        private int _energy { get; set; }
        public Pet(string name = "Garfield")
        {
            _name = name;
            _favFood = "lasagna";
            _energy = 5;
        }
        public void ChangeFavFood(string newFood = "burgers")
        {
            _favFood = newFood;
        }
        public string GetName()
        {
            return _name;
        }
        public int GetEnergy()
        {
            return _energy;
        }
        public string GetFood()
        {
            return _favFood;
        }
        public void FeedPet()
        {
            Console.WriteLine($"Unsure, {_name} sniffs on the dry food and gives you a dissapointed look.");
            _energy++;
        }
        public void FeedPet(string food)
        {
            if (food == _favFood)
            {
                Console.WriteLine($"{_name} is super stoked and devours all of the {_favFood}!");
                int newStat = _energy + 5;
                _energy = newStat;
            }
            else FeedPet();
        }
        public void PlayWithPet()
        {
            Console.WriteLine($"{_name} loves playing! {_name} gets a little tired tho.");
            _energy--;
        }
        public void ShowStats()
        {
            Console.WriteLine($"Name: {_name}\nEnergy: {_energy}");
        }
    }
}
