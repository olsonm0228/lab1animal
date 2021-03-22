using System.Xml.Serialization;
using System;
using System.Collections;


class CreateAnimal{
    public CreateAnimal(){

    }

    public ArrayList AnimalCreation(){
        ArrayList zoo = new ArrayList();
        string choice = "0";
        string continueChoice = "Y";
        string nameHolder = "";
        int numHolder = 0;
        string isFriendly = "";
        while(continueChoice == "Y" || continueChoice == "y"){
            Console.WriteLine("What type of animal do you want to create?\n1:Dog\n2:Cat\n3:Teacher");
            choice = Console.ReadLine();
            switch(choice){
                //Dog
                case "1":
                    Console.WriteLine("What is the dogs name?");
                    nameHolder = Console.ReadLine();
                    Console.WriteLine("Is your dog Friendly? Y/N");
                    isFriendly = Console.ReadLine();
                    if(isFriendly == "n" || isFriendly == "N"){
                        zoo.Add(new Dog(false,nameHolder));
                    } else {
                        //default to friendly dogos
                        zoo.Add(new Dog(true,nameHolder));
                    }
                    break;
                //Cat
                case "2":
                    Console.WriteLine("What is the cats name?");
                    nameHolder = Console.ReadLine();
                    Console.WriteLine("How many mice has it killed?");
                    numHolder = Int32.Parse(Console.ReadLine());
                    zoo.Add(new Cat(numHolder, nameHolder));
                    break;
                //Teacher
                case "3":
                    Console.WriteLine("What is the teachers name?");
                    nameHolder = Console.ReadLine();
                    Console.WriteLine("How old is the teacher?");
                    numHolder = Int32.Parse(Console.ReadLine());
                    zoo.Add(new Teacher(numHolder, nameHolder));
                    break;
                default:
                    Console.WriteLine("Your input was not 1, 2, or 3.");
                    break;
            }
            Console.WriteLine("Do you wish to add more to your zoo? Y/N");
            continueChoice = Console.ReadLine();
        }

        return zoo;
    }

}