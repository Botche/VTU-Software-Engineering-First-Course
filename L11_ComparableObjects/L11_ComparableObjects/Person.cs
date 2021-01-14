namespace L11_ComparableObjects
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person : IPerson
    {
        private int age;
        private string name;

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public int Age { get => this.age; set => this.age = value; }

        public string Name { get => this.name; set => this.name = value; }

        public void PrintName()
        {
            Console.WriteLine($"Name: {this.Name}");
        }
    }
}
