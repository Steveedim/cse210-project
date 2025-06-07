public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly.") { }

    public override void Execute()
    {
        Start();

        int interval = 6;
        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            elapsed += interval;
        }

        End();
    }
}
