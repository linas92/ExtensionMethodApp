﻿using System;
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

            person.Age = "What is your age:".RequestInt();

            person.NumberOfFingers = "How many fingers you have:".RequestFloat();


            Console.ReadLine();
        }
    }
}


