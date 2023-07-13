using System;

namespace ExtensionMethodApp
{
    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = "";

            while (string.IsNullOrWhiteSpace(output))
            {
                Console.WriteLine(message);
                output = Console.ReadLine();
            }
            return output;
        }

        public static int RequestInt(this string message)
        {
            int output = 0;
            bool isValidAge = false;

            while (isValidAge == false)
            {
                Console.WriteLine(message);
                isValidAge = int.TryParse(Console.ReadLine(), out output);
            }
            return output;
        }
        public static float RequestFloat(this string message)
        {
            float output = 0.0f;
            bool isValidFloat = false;

            while (isValidFloat == false)
            {
                Console.WriteLine(message);
                isValidFloat = float.TryParse(Console.ReadLine(),out output);
            }
            return output;
        }
    }
}


