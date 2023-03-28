namespace Viritual_Pet_Simulator
{
    public class Gameplay
    {
        public void Intro()
        {
            Console.WriteLine("WELCOME TO THE DAY CARE\n");
            Console.WriteLine("Write your new pet's name \n or");
            Console.WriteLine("push 'enter' to generate Garfield.\n");
            InputChoice();
        }
        public void InputChoice()
        {
            var mainPlay = new MainPlay();
            var input = Console.ReadLine();
            if (input == "\r" || input == null) RegeneratePet(mainPlay);
            else
            {
                var newPet = new Pet(input);
                mainPlay.PetStartPage(newPet);
            }
        }
        public void RegeneratePet(MainPlay mainPlay)
        {
            var newPet = new Pet();
            mainPlay.PetStartPage(newPet);
        }
    }
}
