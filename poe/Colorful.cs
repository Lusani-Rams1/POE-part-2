using System;

namespace Poe
{
    public class Colorful
    {
        public Colorful()
        {
            // Call AI Design core
            AI_Design();
        }

        // Method for AI Design
        private void AI_Design()
        {
            // Display welcome message
            DisplayMessage("Welcome to the Chatbot", ConsoleColor.Red);
            DisplayMessage("=======================", ConsoleColor.White);

            bool repeat = true;
            while (repeat)
            {
                // AI's prompt
                DisplayMessage("AI Chat -> What's your name? (Type 'no' to exit)", ConsoleColor.Magenta);

                // User response prompt
                Console.Write("User-> ");
                Console.ForegroundColor = ConsoleColor.White;
                string userName = Console.ReadLine();

                // Validate user input
                if (string.IsNullOrWhiteSpace(userName))
                {
                    DisplayMessage("Invalid input. Please enter a valid name.", ConsoleColor.Yellow);
                    continue;
                }

                // Exit condition
                if (userName.ToLower() == "no")
                {
                    repeat = false;
                    DisplayMessage("Goodbye!", ConsoleColor.Green);
                }
                else
                {
                    // Display captured username
                    DisplayMessage($"Welcome, {userName}!", ConsoleColor.Green);
                }
            }

            // Prevent console from closing immediately
            DisplayMessage("Press any key to exit...", ConsoleColor.White);
            Console.ReadKey();
        }

        // Method to display messages in specific colors
        private void DisplayMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}