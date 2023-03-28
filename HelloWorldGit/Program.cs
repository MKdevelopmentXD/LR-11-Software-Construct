using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "log.txt";
        DateTime lastRun;

        // Check if the user wants to print the log file
        if (args.Length > 0 && args[0] == "all")
        {
            if (File.Exists(fileName))
            {
                Console.WriteLine("All runs:");
                foreach (string line in File.ReadAllLines(fileName))
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("No previous runs.");
            }
            return;
        }

        // Read the last run time from the file
        if (File.Exists(fileName))
        {
            string lastRunStr = File.ReadAllText(fileName);
            if (DateTime.TryParse(lastRunStr, out lastRun))
            {
                Console.WriteLine("Last run: {0}", lastRun);
            }
        }
        else
        {
            Console.WriteLine("No previous runs.");
        }

        // Write the current run time to the file
        using (StreamWriter sw = File.AppendText(fileName))
        {
            sw.WriteLine(DateTime.Now.ToString());
        }
    }
}
