// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Specialized;

namespace Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "", breed = "", size = "", age ="" , weight = "", healthStatus = "";
            string choice = "";

            while(choice != "3")
            {
                displayMenu();
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        readDog(ref name, ref breed, ref size, ref age, ref weight, ref healthStatus);
                        break;
                    case "2":
                        showDog(name, breed, size, age, weight, healthStatus);
                        break;
                    case "3":
                        Console.WriteLine("The app is closing...");
                        break;
                    default:
                        Console.WriteLine("The app is closing...");
                        break;
                }
            }

        static void displayMenu()
            {
                Console.WriteLine("---------Dogs---------");
                Console.WriteLine("Option 1: Read a dog");
                Console.WriteLine("Option 2: Display a dog");
                Console.WriteLine("Option 3: The app will close");
                Console.WriteLine("Choose one option!");
            }

        static void readDog(ref string name, ref string breed, ref string size, ref string age, ref string weight, ref string healthStatus)
            {
                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Breed: ");
                breed = Console.ReadLine();

                Console.Write("Size: ");
                size = Console.ReadLine();

                Console.Write("Age: ");
                age = Console.ReadLine();

                Console.Write("Weight: ");
                weight = Console.ReadLine();

                Console.Write("Health Status : ");
                healthStatus = Console.ReadLine();

            }
        static void showDog(string name, string breed, string size, string age, string weight, string healthStatus)
            {
                Console.WriteLine("Dog's details: "); 
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Breed: " + breed);
                Console.WriteLine("Size: " + size);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Weight: " + weight);
                Console.WriteLine("Health Status: " + healthStatus);
            }
        }
    }
}


