using AssignmentCreationalDP.Models;
using AssignmentCreationalDP.Models.Enums;

namespace AssignmentCreationalDP.Builders;

public abstract class CoffeeBuilder
{
    protected readonly List<CoffeeType> CoffeeTypes = new();
    protected readonly List<Milk> MilkList = new();
    protected readonly List<Sugar> SugarList = new();

    public abstract void AddMilk(Milk milk);
    public abstract void AddSugar(Sugar sugar);
    public abstract Coffee GetCoffee();
}