using System;
using System.Collections.Generic;
using System.IO;

namespace poe
{
    public class Memory_Recall
    {
        private readonly string fullPath;

        public Memory_Recall()
        {
            string projectLocation = AppDomain.CurrentDomain.BaseDirectory;
            fullPath = Path.Combine(projectLocation, "Memory.txt");

            EnsureFileExists(); // Make sure file exists before working with it
            List<string> memoryCollected = LoadMemory();

            Console.WriteLine("\nRecalled Memory:");
            foreach (var memory in memoryCollected)
            {
                Console.WriteLine(memory);
            }

            // Add timestamped memory
            memoryCollected.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - New memory added");
            SaveMemory(memoryCollected);
        }

        private void EnsureFileExists()
        {
            if (!File.Exists(fullPath))
            {
                File.Create(fullPath).Close();
                Console.WriteLine("Created new memory file.");
            }
        }

        private List<string> LoadMemory()
        {
            try
            {
                return new List<string>(File.ReadAllLines(fullPath));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading memory: " + ex.Message);
                return new List<string>();
            }
        }

        private void SaveMemory(List<string> memory)
        {
            try
            {
                File.WriteAllLines(fullPath, memory);
                Console.WriteLine("Memory saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving memory: " + ex.Message);
            }
        }
    }
}