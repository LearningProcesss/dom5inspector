namespace Dom5Logic.Odm.Aggrator.Dto;

public class BaseUAggregate
{
    public int id { get; set; }
    public string name { get; set; }
    public IEnumerable<WeaponsAggregate>? weapons { get; set; }
    public int? armor1 { get; set; }
    public int? armor2 { get; set; }
    public int? armor3 { get; set; }
    public int? armor4 { get; set; }
    public int? rt { get; set; }
    public string? reclimit { get; set; }
    public int? basecost { get; set; }
    public int? rcost { get; set; }
    public int? size { get; set; }
    public int? ressize { get; set; }
    public int? hp { get; set; }
    public int? prot { get; set; }
    public int? mr { get; set; }
    public int? mor { get; set; }
    public int? str { get; set; }
    public int? att { get; set; }
    public int? def { get; set; }
    public int? prec { get; set; }
    public int? enc { get; set; }
    public int? mapmove { get; set; }
    public int? ap { get; set; }
}