// Author - Webster B
// Date - 2/10/2025
// Dad Joke Generator 

using System;

namespace Module4Challenge;  

class Program
{
    static void Main()
    {
        // Declare an array of 12 dad jokes
        string[] dadJokes = {
            "Why don't skeletons fight each other? They don't have the guts.",
            "I'm reading a book on anti-gravity. It's impossible to put down!",
            "Why did the scarecrow win an award? Because he was outstanding in his field!",
            "What do you call fake spaghetti? An impasta!",
            "Why did the bicycle fall over? Because it was two-tired!",
            "What do you call cheese that isn't yours? Nacho cheese!",
            "Why can't you give Elsa a balloon? Because she will let it go!",
            "What do you get when you cross a snowman and a vampire? Frostbite!",
            "Why don't eggs tell jokes? They might crack up!",
            "What do you call a bear with no teeth? A gummy bear!",
            "Why did the math book look sad? Because it had too many problems.",
            "What do you call a fish wearing a bowtie? Sofishticated!"
        };

        // Create a Random object to generate random numbers
        Random rnd = new Random();

        // Boolean variable to control the loop
        bool showMoreJokes = true;

        // Main loop to keep showing jokes until the user decides to stop
        while (showMoreJokes)
        {
            // Display two random jokes
            Console.WriteLine("Here are two dad jokes for you:");
            for (int i = 0; i < 2; i++)
            {
                // Generate a random index to select a joke from the array
                int jokeIndex = rnd.Next(0, dadJokes.Length);

                // Display the selected joke
                Console.WriteLine($"{i + 1}. {dadJokes[jokeIndex]}");
            }

            // Ask the user if they want to see more jokes
            Console.Write("\nWould you like to see more dad jokes? (yes/no): ");
            string userResponse = Console.ReadLine().ToLower(); // Convert input to lowercase for easier comparison

            // Check if the user wants to see more jokes
            if (userResponse != "yes")
            {
                // If the user doesn't want more jokes, set showMoreJokes to false to exit the loop
                showMoreJokes = false;

                // Thank the user and exit the program
                Console.WriteLine("Thanks for enjoying the dad jokes! Have a great day!");
            }
            else
            {
                // If the user wants more jokes, add a blank line for readability
                Console.WriteLine();
            }
        }
    }
}