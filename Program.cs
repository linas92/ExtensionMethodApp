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

            person.NumberOfFingers = "How many fingers you have:".RequestFloat();


            Console.ReadLine();
        }
    }
}


/*
Next days plan:
Finish NumberOfFingers method. (seriously, rename it to something like 
Add some messages (when the user enters "wrong" data). 
Maybe rename methods so the naming is more understandable. 
Double check the code to see if its trully readable and easily understandable.
After everthing, clean up spacing, comments and any other issues I might find.
Smile.
*/