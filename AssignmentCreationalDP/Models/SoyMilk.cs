namespace AssignmentCreationalDP.Models;

public class SoyMilk : Milk
{
    public SoyMilk(double percentage) : base(percentage)
    {
        Name = "Soy Milk";
        Percentage = percentage;
    }
}