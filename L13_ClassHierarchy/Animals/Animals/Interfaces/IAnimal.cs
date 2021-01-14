namespace Animals.Animals.Interfaces
{
    public interface IAnimal
    {
        string Name { get; set; }

        int Age { get; set; }

        Gender Gender { get; set; }

        string ProduceSound(); 
    }
}
