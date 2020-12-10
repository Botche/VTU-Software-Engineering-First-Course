namespace P05_CustomTryParse
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            // try - catch || finally

            // try - catch - finally

            #region TryCatch
            //try
            //{
            //    string text = "";

            //    if (string.IsNullOrWhiteSpace(text) == true)
            //    {
            //        throw new ArgumentNullException();
            //    }

            //    int number = int.Parse(text);

            //    Console.WriteLine(number);
            //}
            //catch (ArgumentNullException)
            //{
            //    Console.WriteLine("Argument was null");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Format is not correct");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            IntTryParse("asd", out int number);

            Console.WriteLine(number);
        }

        private static bool IntTryParse(string text, out int number)
        {
            number = default;
            bool isParsed = false;

            try
            {
                number = int.Parse(text);

                isParsed = true;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Parsing was not successful");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }

            return isParsed;
        }
    }
}
