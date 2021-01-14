namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using global::Animals.Animals;
    using global::Animals.Animals.Cats;

    public class StartUp
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();

            string input = Console.ReadLine();
            while (input != "Beast!")
            {
                string typeOfAnimal = input;

                input = Console.ReadLine();

                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                bool isParsed = Enum.TryParse<Gender>(tokens[2], out Gender gender);

                if (isParsed == false)
                {
                    input = Console.ReadLine();

                    continue;
                }

                Type typeAnimal = null;
                if (typeOfAnimal == "Cat")
                {
                    typeAnimal = gender == Gender.Female 
                        ? typeof(Kitten) 
                        : typeof(Tomcat); 
                }
                else
                {
                    Assembly assembly = typeof(Animal).Assembly;
                    foreach (var type in assembly.GetTypes())
                    {
                        if (type.BaseType == typeof(Animal)
                            && type.IsAbstract == false
                            && type.Name == typeOfAnimal)
                        {
                            typeAnimal = type;
                            break;
                        }
                    }
                }

                Animal instance = (Animal)Activator.CreateInstance(typeAnimal, name, age, gender);

                animals.Add(instance);

                input = Console.ReadLine();
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
