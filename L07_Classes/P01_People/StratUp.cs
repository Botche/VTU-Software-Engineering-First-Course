namespace P01_People
{
    using System;

    public class StratUp
    {
        public static void Main()
        {
            try
            {
                Person person = new Person("Pesho", "Petrov", 12);
                Person person2 = new Person("Gosho2");
                Person person3 = new Person("Gosho3");
                Person person4 = new Person("Gosho4");
                Person person5 = new Person("Gosho5");
                Person person6 = new Person("Gosho6");
                Person person7 = new Person("Gosho7");
                Person person8 = new Person("Gosho8");
                Person person9 = new Person("Gosho9");

                // person.ChangeFirstName("Gabriel");
                Console.WriteLine(person.FirstName);
                Console.WriteLine(person.LastName);

                Console.WriteLine(person2.FirstName);
                Console.WriteLine(person2.LastName);

                // Console.WriteLine(person.HappyBirthDay());
                Console.WriteLine(person.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
