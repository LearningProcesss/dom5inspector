
namespace Dom5Logic.Bl;

public class BaseUDto
{
    public int id { get; set; }
    public string? name { get; set; }
    public IEnumerable<WeaponDto>? weapons { get; set; }
}

public class WeaponDto
{
    public int id { get; set; }
    public string? name { get; set; }
}