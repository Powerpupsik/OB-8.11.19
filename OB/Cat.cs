using System;

namespace OB
{
    class Cat : Animal
    {
        public double levelOfCuteness;

        public void Meow()
        {
            Console.WriteLine($"Meow");
            levelOfCuteness -= 0.1;
            levelOfHappiness += 0.1;

        }
        public void ShowLevelOfCuteness()
        {
            Console.WriteLine($"Cat's level of cuteness is {levelOfCuteness}");
        }

        public void HearBarks(int numberOfBarks)
        {
            levelOfHappiness -= 0.1 * numberOfBarks;
        }
    }
}
