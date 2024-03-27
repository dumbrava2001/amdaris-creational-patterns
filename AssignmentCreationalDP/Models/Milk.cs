namespace AssignmentCreationalDP.Models;

public abstract class Milk
{
    public string Name { get; protected set; }
    public double Percentage { get; set; }

    protected Milk(double percentage)
    {
        Percentage = percentage;
    }
}