using AssignmentCreationalDP.Models;
using AssignmentCreationalDP.Models.Enums;

namespace AssignmentCreationalDP.Builders;

public class EspressoCoffeeBuilder : CoffeeBuilder
{
    public EspressoCoffeeBuilder()
    {
        CoffeeTypes.Add(CoffeeType.BLACK_COFEE);
    }

    public override void AddMilk(Milk milk)
    {
        MilkList.Add(milk);
    }

    public override void AddSugar(Sugar sugar)
    {
        SugarList.Add(sugar);
    }

    public override Coffee GetCoffee()
    {
        return new Coffee(CoffeeTypes, MilkList, SugarList);
    }
}