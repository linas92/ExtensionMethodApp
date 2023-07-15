using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.FirstName = "What is your first name:".RequestString();
            
            person.LastName = "What is your last name:".RequestString();

            person.Age = "What is your age:".RequestInt(0, 120); // keep forgetting that ctrl + shift + . shows the overloads.

            person.EyeSight = "How is your eye sight:".RequestFloat(-20,20);


            Console.ReadLine();
        }
    }
}


/*

* Add some messages (when the user enters "wrong" data). 
Something like: Console.WriteLine($"{output} was not a valit input. Please use values from {minValue} to {maxValue}.");

* Add the summary message at the end

 */