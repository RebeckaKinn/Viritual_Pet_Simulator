namespace Viritual_Pet_Simulator
{
    public class MainPlay
    {
        public void Menu(Pet CurrentPet)
        {
            Console.WriteLine("\n1 - Play\n2 - Feed\n3 - Quit\n");
            var userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    PlayWithPet(CurrentPet);
                    break;
                case "2":
                    FeedPet(CurrentPet);
                    break;
                case "3":
                    QuitGame();
                    break;
                default:
                    Menu(CurrentPet);
                    break;
            }
        }
        public void PetStartPage(Pet CurrentPet)
        {
            CheckStats(CurrentPet);
            CurrentPet.ShowStats();
            Menu(CurrentPet);
        }
        public void PlayWithPet(Pet CurrentPet)
        {
            CurrentPet.PlayWithPet();
            PetStartPage(CurrentPet);
        }
        public void FeedPet(Pet CurrentPet)
        {
            var input = Console.ReadLine();
            var chosenFood = input == CurrentPet.GetFood() ? CurrentPet.GetFood() : input;
            CurrentPet.FeedPet(chosenFood);
            PetStartPage(CurrentPet);
        }
        public void QuitGame()
        {
            Console.Clear();
            var gameplay = new Gameplay();
            gameplay.Intro();
        }
        public void CheckStats(Pet CurrentPet)
        {
            var energyLevel = CurrentPet.GetEnergy();
            if (energyLevel > 0) GameOver(CurrentPet);
        }

        public void GameOver(Pet CurrentPet)
        {
            Console.WriteLine("GAME OVER\n");
            Console.WriteLine($"Poor little {CurrentPet.GetName} lot all it's energy");
            Console.WriteLine("and went to sleep.\n");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            QuitGame();
        }
    }
}
