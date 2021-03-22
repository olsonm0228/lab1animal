using System;
using System.Collections;

namespace lab1animal
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList zoo = new ArrayList();
            CreateAnimal creation = new CreateAnimal();
            zoo = creation.AnimalCreation();
            // Lines to Replace Begin Here
            // zoo.Add(new Dog(true, "Bean"));
            // zoo.Add(new Cat(9, "Charlie"));
            // zoo.Add(new Teacher(44, "Stacy Read"));
            // End Lines to Replace

            foreach(Talkable thing in zoo){
                printOut(thing);
            }

        }
        public static void printOut(Talkable p)
        {
            Console.WriteLine(p.Name + " says=" + p.Talk());
        }
    }
}