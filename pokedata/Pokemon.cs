namespace Pokedex;

public class Pokemon
{
    public (List<Ability, Boolean, ushort>) Abilities { get; set; }
    public ushort base_experience { get; set; }
    public List<string>? game_indice { get; }
    public ushort height { get; }
    public List<string>? held_items { get; }
    public int id { get; set; }
    public Boolean is_default { get; }
    public Uri? encounters { get; }
    public List<string> moves { get; }
    public string name { get; }
    public ushort order { get; }
    public List<string>? past_types { get; }
    public Species species { get; }
    public List<Uri> sprites { get; }
    public Stats stats { get; }
    public ushort weight { get; }
}