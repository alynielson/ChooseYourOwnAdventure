using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Player
    {
        //member variables
        public string name;
        public string typeOfPet;


        //constructor
        public Player()
        {

        }

        //member methods
        public void GetTypeOfPet()
        {
            Console.WriteLine("Congratulations! You woke up today as a house pet. Are you a dog or a cat?");
            string typeOfPetResponse = Console.ReadLine();
            string typeOfPetResponseLower = typeOfPetResponse.ToLower();
            string typeOfPetResponseLowerTrimmed = typeOfPetResponseLower.Trim();
            switch (typeOfPetResponseLowerTrimmed)
            {
                case "cat":
                    {
                        typeOfPet = "cat";
                        Console.WriteLine("You are a cat!");
                        break;
                    }
                case "dog":
                    {
                        typeOfPet = "dog";
                        Console.WriteLine("You are a dog!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I know you don't have fingers, but you need to type better.");
                        GetTypeOfPet();
                        break;
                    }
            }
            GetNameOfPlayer();
        }
        public void GetNameOfPlayer()
        {
            Console.WriteLine("What is your name, " + typeOfPet + "?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " the " + typeOfPet);
            Console.ReadLine();
        }
    }
}
