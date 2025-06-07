public class ReflectionActivity : Activity
{
    private static readonly string[] Prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] Questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this in mind in the future?"
    };

    public ReflectionActivity() 
        : base("Reflection Activity", "This activity will help you reflect on times in your life when you've shown strength.") { }

    public override void Execute()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine(Prompts[rand.Next(Prompts.Length)]);
        ShowSpinner(4);

        int elapsed = 0;
        while (elapsed < _duration)
        {
            string question = Questions[rand.Next(Questions.Length)];
            Console.WriteLine(question);
            ShowSpinner(5);
            elapsed += 5;
        }

        End();
    }
}
