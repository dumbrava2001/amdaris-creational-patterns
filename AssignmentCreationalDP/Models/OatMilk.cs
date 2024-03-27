namespace AssignmentCreationalDP.Models;

public class OatMilk : Milk
{
    public OatMilk(double percentage) : base(percentage)
    {
        Name = "Oat Milk";
        Percentage = percentage;
    }
}