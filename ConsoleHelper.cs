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
    }
}


