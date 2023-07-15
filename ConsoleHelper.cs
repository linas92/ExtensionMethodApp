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

        public static int RequestInt(this string message, int minValue, int maxValue)
        {
            return message.RequestInt(true, minValue, maxValue);
        }

        public static int RequestInt(this string message)
        {
            return message.RequestInt(false);
        }

        private static int RequestInt(this string message, bool useMinMax, int minValue = 0, int maxValue = 0) 
        {
            int output = 0;
            bool isValidAge = false;
            bool isInvalidAgeRange = true;

            while (isValidAge == false || isInvalidAgeRange == false)
            {
                Console.WriteLine(message);
                isValidAge = int.TryParse(Console.ReadLine(), out output);

                if (useMinMax == true)
                {
                    isInvalidAgeRange = (output >= minValue && output <= maxValue);
                }
            }
            return output;
        }

        public static float RequestFloat(this string message, float minValue, float maxValue)
        {
            return message.RequestFloat(true, minValue, maxValue);
        }

        public static float RequestFloat(this string message)
        {
            return message.RequestFloat(false);
        }

        private static float RequestFloat(this string message, bool useMinMax, float minValue = 0, float maxValue = 0)
        {
            float output = 0;
            bool isValidEyeSight = false;
            bool isInvalidEyeSightRange = true;

            while (isValidEyeSight == false || isInvalidEyeSightRange == false)
            {
                Console.WriteLine(message);
                isValidEyeSight = float.TryParse(Console.ReadLine(), out output);

                if (useMinMax == true)
                {
                    isInvalidEyeSightRange = (output >= minValue && output <= maxValue);
                }
            }
            return output;
        }
    }
}


