namespace P02_Abstract
{
    using System;

    // LISTS AND ADDITIONAL EXERCISE
    public class StartUp
    {
        public static void Main()
        {
            Cat cat = new Cat("Cat", 12);
            cat.Lives = 9;
            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Lives);
            Console.WriteLine(cat.FeedMe());
            Console.WriteLine(cat.Drink());

            Dog dog = new Dog("Dog", 10);
            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.FeedMe());
            Console.WriteLine(dog.Drink());
        }
    }

    public abstract class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        protected Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual string FeedMe()
        {
            return $"Feed me, I'm hungry! {this.GetType().Name}";
        }

        public abstract string Drink();
    }

    public class Cat : Animal
    {
        public Cat(string name, int age)
            : base(name, age)
        {

        }

        public int Lives { get; set; }

        public override string Drink()
        {
            return "Drinking vodka!";
        }

        public override string FeedMe()
        {
            return "Meow, meow! I'm hungry!!!";
        }
    }

    public class Dog : Animal
    {
        public Dog(string name, int age)
            : base(name, age)
        {

        }

        public override string Drink()
        {
            return "Drinking water.";
        }
    }
}
