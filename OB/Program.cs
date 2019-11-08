using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OB
{

    class Program
    {



        static void Main(string[] args)
        {
            /*//KASS
            Animal nurr = new Animal();
            nurr.name = "Nurr";
            nurr.age = 15;
            nurr.levelOfHappiness=0.1;
            nurr.PrintAnimalBaseInfo();*/

            //KOER
            Dog scooby = new Dog();  //esimene 'scooby' on objekti nimi
            scooby.name = "ScoobyDoo";
            scooby.age = 1;
            scooby.levelOfHappiness = 0.1;
            scooby.spotCount = 5;
            scooby.PrintAnimalBaseInfo();
            scooby.Bark();

            Cat miisu = new Cat();
            miisu.name = "Miisu";
            miisu.age = 2;
            miisu.levelOfHappiness = 0.5;
            miisu.levelOfCuteness = 1;
            //Cat meows
            for (int i = 0; i < 5; i++)
            {
                miisu.Meow();
            }
            miisu.ShowLevelOfCuteness();

            //Dog barks
            //pane koer 10x haukuma
            for (int i = 0; i <20; i++)
            {
                scooby.Bark();
            }

            miisu.HearBarks(scooby.numberOfBarks);

            if (miisu.levelOfHappiness < 0)
            {
                Console.WriteLine($"{miisu.name} died of stress");
                miisu = null;
            }

            scooby.ShowNumberOfDogSpots();
            scooby.ShowLevelOfHappiness(); //VÄGA OLULINE ON ASUKOHT!!! KUI ÜLEVAL, SIIS EI NÄITA SEDA WUF-COUNT HAPPINESSI




          

            Console.ReadLine();









        }
    }
}
