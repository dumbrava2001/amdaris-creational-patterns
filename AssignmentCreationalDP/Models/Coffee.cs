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
        stringBuilder.AppendJoin(',', CoffeeTypes);

        stringBuilder.Append("\nMilk List:\n");
        stringBuilder.AppendJoin(',', MilkList);

        stringBuilder.Append("\nSugar List:\n");
        stringBuilder.AppendJoin(',', SugarList);

        stringBuilder.AppendLine();
        return stringBuilder.ToString();
    }
}