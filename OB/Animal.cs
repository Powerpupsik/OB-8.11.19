using System;

namespace OB
{
    //KLASSIDE LOOMINE. LISATAKSE ERALDI FAILI PÄRAST.
    class Animal
    {
        public string name;
        public int age;
        public double levelOfHappiness;

        public void PrintAnimalBaseInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Level of happiness: {levelOfHappiness}");
        }

        public void ShowLevelOfHappiness()
        {
            Console.WriteLine($"Level of happiness: {levelOfHappiness}");
        }
        
    }
}
