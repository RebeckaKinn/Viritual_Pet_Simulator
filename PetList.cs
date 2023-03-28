namespace Viritual_Pet_Simulator
{
    public class PetList
    {
        private List<Pet> _pets { get; set; }
        public PetList()
        {
            _pets = new List<Pet>();
        }
        public void AddPet(Pet newPet)
        {
            _pets.Add(newPet);
        }
    }
}
