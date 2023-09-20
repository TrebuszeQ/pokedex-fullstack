namespace Pokedex;

public class Stats
{
    // public readonly ushort id { get; }
    public ushort base_stat { get; set; }
    public ushort effort { get; set; }
    public List<Stat> stat { get; set; }
    public List<Types> types { get; set; }

    // public Stats(ushort id)
    // {
    //     this.id++;
    // }
}
