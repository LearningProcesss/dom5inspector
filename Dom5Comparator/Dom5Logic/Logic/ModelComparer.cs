
using System.Reflection;

namespace Dom5Logic.Logic;

public class ModelComparer : IModelComparer
{
    public IEnumerable<Variance> Compare<T>(T leftUnit, T rightUnit)
    {
        List<Variance> variances = new List<Variance>();

        PropertyInfo[] propertyInfosLeft = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (PropertyInfo property in propertyInfosLeft)
        {
            CompareProperty(leftUnit, rightUnit, variances, property);
        }

        return variances;
    }

    public void CompareProperty<T>(T leftUnit, T rightUnit, List<Variance> variances, PropertyInfo property)
    {
        object? leftValue = property.GetValue(leftUnit, null);

        object? rightValue = property.GetValue(rightUnit, null);

        if (!Equals(leftValue, rightValue))
        {
            variances.Add(new Variance { Name = property.Name, LeftValue = leftValue.ToString(), RightValue = rightValue.ToString() });
        }
    }

    public IEnumerable<Variance> Compare<T>(T leftUnit, T rightUnit, params string[] skipProperties)
    {
        List<Variance> variances = new List<Variance>();

        PropertyInfo[] propertyInfosLeft = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(prop => !skipProperties.Contains(prop.Name)).ToArray();

        foreach (PropertyInfo property in propertyInfosLeft)
        {
            CompareProperty(leftUnit, rightUnit, variances, property);
        }

        return variances;
    }
}