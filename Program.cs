using System;
using System.Collections.Specialized;

namespace Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            List<Dog> dogList = new List<Dog>();

            while(choice != "5")
            {
                Console.Clear();
                displayMenu();
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        readDog(ref dogList);
                        break;
                    case "2":
                        showLastDog(ref dogList);
                        break;
                    case "3":
                        showAllDogs(ref dogList);
                        break;
                    case "4":
                        deleteDog(ref dogList);
                        break;
                    case "5":
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
                Console.WriteLine("Option 2: Display last dog");
                Console.WriteLine("Option 3: Display all the dogs");
                Console.WriteLine("Option 4: Delete a dog");
                Console.WriteLine("Option 5: The app will close");
                Console.WriteLine("Choose one option!");
            }

            static void readDog(ref List<Dog> dogList)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Breed: ");
                string breed = Console.ReadLine();

                Console.Write("Size: ");
                string size = Console.ReadLine();

                Console.Write("Age: ");
                int age = Int32.Parse(Console.ReadLine());

                Console.Write("Weight: ");
                int weight = Int32.Parse(Console.ReadLine());

                Console.Write("Health Status : ");
                string healthStatus = Console.ReadLine();

                Dog dog = new Dog(name, breed, size, age, weight, healthStatus);

                dogList.Add(dog);
            }

            static void showLastDog(ref List<Dog> dogList)
            {
                Console.WriteLine("Dog's details: ");
                Console.WriteLine("Name: " + dogList.Last().name);
                Console.WriteLine("Breed: " + dogList.Last().breed);
                Console.WriteLine("Size: " + dogList.Last().size);
                Console.WriteLine("Age: " + dogList.Last().age);
                Console.WriteLine("Weight: " + dogList.Last().weight);
                Console.WriteLine("Health Status: " + dogList.Last().healthStatus);
                Console.Read();
            }

            static void showAllDogs(ref List<Dog> dogList)
            {
                foreach(Dog dog in dogList)
                {
                    Console.WriteLine("Dog's details: ");
                    Console.WriteLine("Name: " + dog.name);
                    Console.WriteLine("Breed: " + dog.breed);
                    Console.WriteLine("Size: " + dog.size);
                    Console.WriteLine("Age: " + dog.age);
                    Console.WriteLine("Weight: " + dog.weight);
                    Console.WriteLine("Health Status: " + dog.healthStatus);
                    Console.WriteLine("-------");
                }
                Console.Read();
            }

            static void deleteDog(ref List<Dog> dogList)
            {
                Console.Write("Type the name of the dog you want to delete: ");
                string deletedDog = Console.ReadLine();

                Dog dogToDelete = dogList.Find(d => d.name == deletedDog);

                dogList.Remove(dogToDelete);
            }
        }
    }
}


