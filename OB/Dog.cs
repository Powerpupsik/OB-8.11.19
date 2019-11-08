using System;

namespace OB
{
    //Inheritance
    class Dog : Animal
    {
        public int spotCount = 0;
        public int numberOfBarks = 0;



        public void Bark()
        {
            Console.WriteLine("Wuf");
            numberOfBarks++;
            levelOfHappiness += 0.1;
            //add 5 spots every time dog barks
            spotCount += 5;

            //nüüd spotid 1-5, tee randomiga




            int randomSpots;
            Random rnd = new Random();
            randomSpots = rnd.Next(0, 6);
            spotCount += randomSpots;

            
        }

        public void ShowNumberOfDogSpots()
        {
            //display the number of spots
            Console.WriteLine($"{name} has now {spotCount} number of spots.");
        }
    }
}
