using System.Text;
using AssignmentCreationalDP.Models.Enums;

namespace AssignmentCreationalDP.Models;

public class Coffee
{
    public List<CoffeeType> CoffeeTypes { get; }
    public List<Milk> MilkList { get; }
    public List<Sugar> SugarList { get; }

    public Coffee(List<CoffeeType> coffeeTypes, List<Milk> milkList, List<Sugar> sugarList)
    {
        CoffeeTypes = coffeeTypes;
        MilkList = milkList;
        SugarList = sugarList;
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder("\nCoffeeTypes:\n");
        foreach (var coffeeType in CoffeeTypes)
        {
            stringBuilder.AppendJoin(',', coffeeType);
        }

        stringBuilder.Append("\nMilk List:\n");
        foreach (var milk in MilkList)
        {
            stringBuilder.AppendJoin(',', milk);
        }

        stringBuilder.Append("\nSugar List:\n");
        foreach (var sugar in SugarList)
        {
            stringBuilder.AppendJoin(',', sugar);
        }

        return stringBuilder.ToString();
    }
}