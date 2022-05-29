
using System.Reflection;

namespace Dom5Logic.Logic;

public interface IModelComparer
{
   IEnumerable<Variance> Compare<T>(T leftUnit, T rightUnit);
   IEnumerable<Variance> Compare<T>(T leftUnit, T rightUnit, params string[] skipProperties);
   void CompareProperty<T>(T leftUnit, T rightUnit, List<Variance> variances, PropertyInfo property);
}