namespace P07_SumOfVowels
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            const int A_VOWEL_VALUE = 1;
            const int E_VOWEL_VALUE = 2;
            const int I_VOWEL_VALUE = 3;
            const int O_VOWEL_VALUE = 4;
            const int U_VOWEL_VALUE = 5;

            const char A_VOWEL = 'a';
            const char E_VOWEL = 'e';
            const char I_VOWEL = 'i';
            const char O_VOWEL = 'o';
            const char U_VOWEL = 'u';

            string text = Console.ReadLine();

            int sumOfVowels = 0;
            for (int index = 0; index < text.Length; index++)
            {
                switch (text[index])
                {
                    case A_VOWEL:
                        sumOfVowels += A_VOWEL_VALUE;
                        break;
                    case E_VOWEL:
                        sumOfVowels += E_VOWEL_VALUE;
                        break;
                    case I_VOWEL:
                        sumOfVowels += I_VOWEL_VALUE;
                        break;
                    case O_VOWEL:
                        sumOfVowels += O_VOWEL_VALUE;
                        break;
                    case U_VOWEL:
                        sumOfVowels += U_VOWEL_VALUE;
                        break;
                }
            }

            Console.WriteLine(sumOfVowels);
        }
    }
}
