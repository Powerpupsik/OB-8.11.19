﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{

    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person();
            newPerson.FirstName = "Raima";
            newPerson.LastName = "Levistu";

            newPerson.Introduce();

            Console.ReadLine();
        }

        
    }
}
