using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool result = PasswordValidator(password);
            if (result)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool NumberOfCharactersInPass(string password)
        {
            bool hasChars = false;

            if (password.Length >= 6 && password.Length <= 10)
            {
                hasChars = true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            return hasChars;
        }
        static bool DigitsInPass(string password) //от 48 до 57
        {
            bool hasTwoDigits = false;
            int digitsCounter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                for (char j = (char)48; j <= (char)57; j++)
                {
                    if (password[i] == j)
                    {
                        digitsCounter++;
                    }
                    if (digitsCounter == 2)
                    {
                        hasTwoDigits = true;

                    }
                }
            }
            if (hasTwoDigits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            return hasTwoDigits;
        }
        static bool OnlyLettersAndDigits(string password)
        {
            bool hasLetersAndDigits = false;

            foreach (char letterOrDigit in password)
            {
                if (char.IsLetterOrDigit(letterOrDigit))
                {
                    hasLetersAndDigits = true;
                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    hasLetersAndDigits = false;
                    break;
                }
            }

            return hasLetersAndDigits;
        }
        static bool PasswordValidator(string password)
        {
            bool passwordValidation = false;
            bool charsInPass = NumberOfCharactersInPass(password);
            bool lettersAndDigits = OnlyLettersAndDigits(password);
            bool digitsInPass = DigitsInPass(password);

            if (charsInPass && digitsInPass && lettersAndDigits)
            {
                passwordValidation = true;
            }
            return passwordValidation;
        }
    }
}
