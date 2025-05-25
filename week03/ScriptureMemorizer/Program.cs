using System;

class Program
{
    static void Main(string[] args)
    {
        // Example Scripture: Proverbs 3:5-6
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding. " +
                      "In all thy ways acknowledge him and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            SafeClearConsole();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to end.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();

            if (scripture.AllWordsHidden())
            {
                SafeClearConsole();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }
        }
    }

    static void SafeClearConsole()
    {
        try
        {
            if (!Console.IsOutputRedirected)
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\n--- (Console.Clear not supported in this environment) ---\n");
            }
        }
        catch (IOException)
        {
            Console.WriteLine("\n--- (Console.Clear failed) ---\n");
        }
        catch (PlatformNotSupportedException)
        {
            Console.WriteLine("\n--- (Console.Clear not supported on this platform) ---\n");
        }
    }
}
