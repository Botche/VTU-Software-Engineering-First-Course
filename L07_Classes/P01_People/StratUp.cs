namespace P01_People
{
    using System;

    public class StratUp
    {
        public static string Text = "aasd";

        public static void Main()
        {
            try
            {
                Person person = new Person("Pesho", "Petrov", 20);
                Person person2 = new Person("Gosho");

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
