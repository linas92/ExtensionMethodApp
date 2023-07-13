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

        public static int RequestInt(this int message)
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
    }
}


