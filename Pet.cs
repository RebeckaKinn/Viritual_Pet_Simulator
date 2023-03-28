namespace Viritual_Pet_Simulator
{
    public class Pet
    {
        private string _name { get; set; }
        private string _favFood { get; set; }
        private int _energy { get; set; }
        public Pet()
        {
            _name = "Pusur";
            _favFood = "Lasagna";
            _energy = 5;
        }
        public Pet(string name = "Pusur")
        {
            _name = name;
            _favFood = "Lasagna";
            _energy = 5;
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
        public void FeedPet(string food)
        {
            if (food == _favFood)
            {
                Console.WriteLine($"{_name} is super stoked and devours all of the {_favFood}!");
                _energy++;
            }
            else
            {
                Console.WriteLine($"Unsure, {_name} sniffs on the {food} and gives you a dissapointed look.");
            }
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
