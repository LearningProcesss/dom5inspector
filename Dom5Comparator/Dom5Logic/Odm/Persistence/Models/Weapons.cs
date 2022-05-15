namespace Dom5Logic.Odm.Persistence.Models;

public class Weapons : IModel
{
    public int id { get; set; }
    public string? name { get; set; }
    public int effect_record_id { get; set; }
    public int att { get; set; }
    public int def { get; set; }
    public int len { get; set; }
    public int nratt { get; set; }
    public int ammo { get; set; }
    public int secondaryeffect { get; set; }
    public int secondaryeffectalways { get; set; }
    public int rcost { get; set; }
    public int weapon { get; set; }
    public string end { get; set; }
}