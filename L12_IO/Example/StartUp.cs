namespace Example
{
    using System;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            const string path = "../../../text.txt";

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("This is text");
                writer.WriteLine("This is text");
                writer.WriteLine("This is text");
                writer.WriteLine("This is text");
                writer.WriteLine("This is text");
                writer.WriteLine("This is text");
                writer.WriteLine("This is text");
                writer.WriteLine("This is text");
                writer.WriteLine("This is text");
                writer.WriteLine("This is text");
                writer.WriteLine("This is text");
                writer.WriteLine("This is text");
            }

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    int counter = 0;
                    while (reader.EndOfStream != true)
                    {
                        counter++;
                        Console.WriteLine($"Line {counter}: {reader.ReadLine()}");
                    }
                }
            }

            File.Delete(path);
        }
    }
}
