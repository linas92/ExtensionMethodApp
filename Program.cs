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
            
            person.LastName = "What is your first name:".RequestString();

            Console.WriteLine("What is your first name:");
            person.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your first name:");
            person.NumberOfFingers = int.Parse(Console.ReadLine());


            Console.ReadLine();
        }
    }
}


