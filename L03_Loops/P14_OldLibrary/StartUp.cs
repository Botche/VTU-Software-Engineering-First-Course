namespace P14_OldLibrary
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            const string textWhenBookIsNotThere = "The book you search is not here! \nYou checked {0} books.";
            const string textWhenBookIsThere = "You checked {0} books and found it.";

            string bookToFind = Console.ReadLine();
            int countOfBooks = int.Parse(Console.ReadLine());

            int counter = 0;
            bool isBookInTheLibrary = false;
            while (counter < countOfBooks)
            {
                string book = Console.ReadLine();
                counter++;

                if (book.ToLower() == bookToFind.ToLower())
                {
                    isBookInTheLibrary = true;
                    break;
                }
            }

            string text = string.Format(textWhenBookIsNotThere, counter);

            if (isBookInTheLibrary == true)
            {
                text = string.Format(textWhenBookIsThere, counter);
            }

            Console.WriteLine(text);
        }
    }
}
