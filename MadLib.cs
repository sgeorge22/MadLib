using System;
using System.Collections.Generic;
using System.Text;

namespace MadLib
{
    class MadLib
    {
        public void MadLibStory()
        {
            /*
            Mad Libs Fun! 
            Author: Sarah George
            */

            // Let the user know that the program is starting:
            Console.WriteLine("Welcome to Mad Libs Fun!");

            // Give the Mad Lib a title:
            string title = "What a Day!";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            Console.Write("Enter an color: ");
            string color = Console.ReadLine();

            Console.Write("Enter a mood: ");
            string mood = Console.ReadLine();

            Console.Write("Enter a texture: ");
            string texture = Console.ReadLine();

            Console.WriteLine("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.WriteLine("Enter a noun for an item: ");
            string itemNoun = Console.ReadLine();

            Console.WriteLine("Enter a noun for a humanoid: ");
            string humanoid = Console.ReadLine();

            Console.WriteLine("Enter an animal: ");
            string animal = Console.ReadLine();

            Console.WriteLine("Enter a food: ");
            string food = Console.ReadLine();

            Console.WriteLine("Enter a fruit: ");
            string fruit = Console.ReadLine();

            Console.WriteLine("Enter a Superhero: ");
            string superhero = Console.ReadLine();

            Console.WriteLine("Enter a country: ");
            string country = Console.ReadLine();

            Console.WriteLine("Enter a dessert: ");
            string dessert = Console.ReadLine();

            Console.WriteLine("Enter a year: ");
            string year = Console.ReadLine();

            // The template for the story:
            string story = $"This morning {name} woke up feeling {color}. " +
                $"'It is going to be a {mood} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. " +
                $"They began to {verb} to the rhythm of the {itemNoun}, which made all the {fruit}s very {texture}. " +
                $"Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. " +
                $"{name} woke up in the year {year}, in a world where {humanoid}s ruled the world.";

            // Print the story:
            Console.WriteLine(story);
        }
    }
}
