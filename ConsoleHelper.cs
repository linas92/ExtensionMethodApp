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

        }

        public static int RequestInt(this string message)
        {
            
        }

        // private external method to overload RequestInt
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
                    isInvalidAgeRange = (output >= minValue && output <= maxValue); // thank you intelliSense for finishing this as I ran out of brain
                    //if (output >= minValue && output <= maxValue)
                    //{
                    //    isInvalidAgeRange = true;
                    //}
                    //else
                    //{
                    //    isInvalidAgeRange = true;
                    //}
                    // left the commented "longer" code so I can ask if the "shorter" way isn't too hard to read
                }
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


