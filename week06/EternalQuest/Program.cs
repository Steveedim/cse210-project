using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static GoalManager goalManager = new GoalManager();

    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\nEternal Quest");
            Console.WriteLine($"Total Score: {goalManager.TotalScore}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: goalManager.CreateGoal(); break;
                case 2: goalManager.DisplayGoals(); break;
                case 3: goalManager.SaveGoals(); break;
                case 4: goalManager.LoadGoals(); break;
                case 5: goalManager.RecordEvent(); break;
            }

        } while (choice != 6);
    }
}
