public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int timesCompleted = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _targetCount)
        {
            _timesCompleted++;
            if (_timesCompleted == _targetCount)
                return _points + _bonusPoints;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _timesCompleted >= _targetCount;

    public override string GetStatus()
        => IsComplete() ? "[X]" : $"[{_timesCompleted}/{_targetCount}]";

    public override string Serialize()
        => $"ChecklistGoal|{_name}|{_description}|{_points}|{_targetCount}|{_bonusPoints}|{_timesCompleted}";
}
