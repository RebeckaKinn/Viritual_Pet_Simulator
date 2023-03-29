namespace Viritual_Pet_Simulator
{
    public class MainPlay
    {
        public void Menu(Pet CurrentPet)
        {
            Console.WriteLine("\n1 - Play\n2 - Feed\n3 - Change favourite food\n4 - Quit\n");
        }
        public void ReadMenuInput(Pet CurrentPet)
        {
            CheckStats(CurrentPet);
            CurrentPet.ShowStats();
            var userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    PlayWithPet(CurrentPet);
                    break;
                case "2":
                    Console.Clear();
                    FeedPet(CurrentPet);
                    break;
                case "3":
                    Console.Clear();
                    NewFavFood(CurrentPet);
                    break;
                case "4":
                    Console.Clear();
                    QuitGame();
                    break;
                default:
                    Menu(CurrentPet);
                    break;
            }
        }
        public void PetStartPage(Pet CurrentPet)
        {
            Menu(CurrentPet);
            ReadMenuInput(CurrentPet);
        }
        public void PlayWithPet(Pet CurrentPet)
        {
            CurrentPet.PlayWithPet();
            ReadMenuInput(CurrentPet);
        }
        public void FeedPet(Pet CurrentPet)
        {
            Console.WriteLine($"What would you like to feed {CurrentPet.GetName()} with?");
            var input = Console.ReadLine();
            var chosenFood = input == CurrentPet.GetFood() ? CurrentPet.GetFood() : input;
            CurrentPet.FeedPet(chosenFood);
            ReadMenuInput(CurrentPet);
        }
        public void QuitGame()
        {
            Console.Clear();
            var gameplay = new Gameplay();
            gameplay.Intro();
        }
        public void NewFavFood(Pet CurrentPet)
        {
            Console.WriteLine("What is your pet's new favourite food?\n");
            var newFood = Console.ReadLine();
            CurrentPet.ChangeFavFood(newFood);
            Console.WriteLine("Food updated!\n");
            ReadMenuInput(CurrentPet);
        }
        public void CheckStats(Pet CurrentPet)
        {
            int energyLevel = CurrentPet.GetEnergy();
            if (energyLevel == 0) GameOver(CurrentPet);
        }

        public void GameOver(Pet CurrentPet)
        {
            Console.WriteLine("GAME OVER\n");
            Console.WriteLine($"Poor little {CurrentPet.GetName()} lot all it's energy");
            Console.WriteLine("and went to sleep.\n");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            QuitGame();
        }
    }
}
