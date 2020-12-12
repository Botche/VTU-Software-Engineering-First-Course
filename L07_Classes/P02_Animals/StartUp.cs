namespace P02_Abstract
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Cat cat = new Cat();
            Console.WriteLine(cat.Name);
            
            Dog dog = new Dog();
            Console.WriteLine(dog.Name);
        }
    }

    public abstract class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public void Method()
        {

        }
    }

    public class Cat : Animal
    {
        
    }

    public class Dog : Animal
    {

    }
}
