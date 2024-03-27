namespace AssignmentCreationalDP.Models;

public abstract class Milk
{
    public string Name { get; protected init; }
    public double Percentage { get; protected init; }

    protected Milk(double percentage)
    {
        Percentage = percentage;
    }
    
    public override string ToString()
    {
        return $"{Name} {Percentage}%";
    }
}