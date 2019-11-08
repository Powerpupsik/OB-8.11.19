using System;

namespace Person
{
    public class Person
    {
        public string FirstName; //ingl.k FIELDS-omadused, mitte muutujad
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {FirstName} {LastName}");

        }
    }
}
