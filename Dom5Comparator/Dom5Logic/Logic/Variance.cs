
namespace Dom5Logic.Logic;

public class Variance : IEquatable<Variance>
{
    public string Name { get; init; }
    public string LeftValue { get; init; }
    public string RightValue { get; init; }

    public bool Equals(Variance? other)
    {
        return other.Name == this.Name && other.LeftValue == this.LeftValue && other.RightValue == this.RightValue;
    }
}

public enum VarianceOperand {
    
}