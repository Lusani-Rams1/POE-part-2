using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Poe
{
    public class User_Interface
    {
        private Dictionary<string, string> responses = new Dictionary<string, string>();
        private HashSet<string> ignoreWords = new HashSet<string>();
        private string userName;

        public User_Interface()
        {
            StoreIgnoreWords();
            StoreResponses();
            AI_Design();
        }

        private void AI_Design()
        {
            DisplayMessage("Welcome to the Chatbot!", ConsoleColor.Red);
            DisplayMessage("==========================", ConsoleColor.White);

            Console.WriteLine("AI Chat -> What's your name? ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("User-> ");
            userName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userName))
            {
                DisplayMessage("Invalid input. Please enter a valid name.", ConsoleColor.Yellow);
                AI_Design();
                return;
            }

            DisplayMessage($"Hello, {userName}! Ask me anything. Type 'exit' to exit", ConsoleColor.Cyan);

            while (true)
            {
                AskQuestion();
            }
        }

        private void AskQuestion()
        {
            Console.WriteLine("Enter your question");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("User-> ");
            string question = Console.ReadLine()?.Trim().ToLower();

            if (string.IsNullOrEmpty(question))
            {
                DisplayMessage("You must enter a valid question!", ConsoleColor.Red);
            }
            else
            {
                ProcessQuestion(question);
            }
        }

        private void ProcessQuestion(string question)
        {
            string[] words = question.Split(' ');

            var filteredWords = words.Where(word => !ignoreWords.Contains(word)).ToList();

            foreach (var word in filteredWords)
            {
                if (responses.ContainsKey(word))
                {
                    Console.WriteLine(responses[word]);
                    DisplayMessage("===========================", ConsoleColor.White);
                    Console.WriteLine("Ask another question!", ConsoleColor.Cyan);
                    return;
                }
            }

            if (question.ToLower() == "exit")
            {
                DisplayMessage("Goodbye!", ConsoleColor.Green);
                Environment.Exit(0);
            }

            DisplayMessage("I am sorry, I do not understand the question.", ConsoleColor.Red);
        }

        private void StoreResponses()
        {
            responses["passwords"] = "Strong passwords protect accounts from hackers.";
            responses["security"] = "Strong passwords protect accounts from hackers.";
            responses["cybersecurity"] = "Cybersecurity defends computers and networks from digital threats.";
            responses["computers"] = "Cybersecurity defends computers and networks from digital threats.";
            responses["networks"] = "Cybersecurity defends computers and networks from digital threats.";
            responses["phishing"] = "Phishing scams trick users into revealing sensitive information.";
            responses["fraud"] = "Phishing scams trick users into revealing sensitive information.";
            responses["email"] = "Phishing scams trick users into revealing sensitive information.";
            responses["2fa"] = "Two-factor authentication (2FA) provides extra security.";
            responses["authentication"] = "Two-factor authentication (2FA) provides extra security.";
            responses["wifi"] = "Public Wi-Fi is insecure and vulnerable to cyber attacks.";

            Random rand = new Random();
            var randomResponse = responses.Values.ElementAt(rand.Next(responses.Count));
            Console.WriteLine($"Cybersecurity Tip: {randomResponse}");
        }

        private void StoreIgnoreWords()
        {
            var commonWords = new[] { "tell", "how", "me", "about", "what", "is", "the", "to", "a", "an", "and", "or", "in", "i", "would", "like" };
            foreach (var word in commonWords)
            {
                ignoreWords.Add(word);
            }
        }

        private void DisplayMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}