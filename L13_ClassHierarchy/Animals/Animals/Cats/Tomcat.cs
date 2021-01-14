namespace Animals.Animals.Cats
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
