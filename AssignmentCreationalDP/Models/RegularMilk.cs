namespace AssignmentCreationalDP.Models;

public class RegularMilk: Milk
{
    public RegularMilk(double percentage) : base(percentage)
    {
        Name = "Regular Milk";
        Percentage = percentage;
    }
}