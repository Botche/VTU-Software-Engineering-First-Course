namespace Animals.Animals.Cats
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
