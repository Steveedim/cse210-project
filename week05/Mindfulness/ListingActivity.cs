public class ListingActivity : Activity
{
    private static readonly string[] Prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "When have you felt peace this month?",
        "Who are your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Activity", "This activity will help you reflect on the good things in your life.") { }

    public override void Execute()
    {
        Start();

        Random rand = new Random();
        Console.WriteLine(Prompts[rand.Next(Prompts.Length)]);
        Console.WriteLine("You may begin in:");
        ShowCountdown(3);

        int startTime = Environment.TickCount;
        List<string> items = new List<string>();

        while ((Environment.TickCount - startTime) / 1000 < _duration)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input);
        }

        Console.WriteLine($"You listed {items.Count} items.");
        End();
    }
}
