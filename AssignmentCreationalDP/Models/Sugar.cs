namespace AssignmentCreationalDP.Models;

public class Sugar
{
    public string Name { get; }

    public Sugar(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"{Name}";
    }
}