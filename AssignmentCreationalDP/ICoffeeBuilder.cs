using AssignmentCreationalDP.Models;

namespace AssignmentCreationalDP;

public interface ICoffeeBuilder
{
    void AddMilk(Milk milk);
    void AddSugar();
    Coffee GetCoffee();
}