public static class GoalFactory
{
    public static Goal Deserialize(string data)
    {
        var parts = data.Split('|');
        string type = parts[0];

        switch (type)
        {
            case "SimpleGoal":
                return new SimpleGoal(
                    parts[1], 
                    parts[2], 
                    int.Parse(parts[3]), 
                    bool.Parse(parts[4]) 
                );

            case "EternalGoal":
                return new EternalGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3])
                );

            case "ChecklistGoal":
                return new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]), 
                    int.Parse(parts[4]), 
                    int.Parse(parts[5]), 
                    int.Parse(parts[6]) 
                );

            default:
                throw new Exception("Unknown goal type");
        }
    }
}
