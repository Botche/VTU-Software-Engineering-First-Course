namespace Animals.Animals
{
    using System.Text;

    using global::Animals.Animals.Interfaces;

    public abstract class Animal : IAnimal
    {
        private string name;
        private int age;
        private Gender gender;

        protected Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get => this.name; set => this.name = value; }

        public int Age { get => this.age; set => this.age = value; }

        public Gender Gender { get => this.gender; set => this.gender = value; }

        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder
                .AppendLine(this.GetType().Name)
                .AppendLine($"{this.name} {this.age} {this.gender}")
                .AppendLine($"{this.ProduceSound()}");

            return stringBuilder.ToString().Trim();
        }
    }
}
