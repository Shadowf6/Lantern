public class Spell
{
    public string name;
    public int cost;

    public Spell(string name, int cost)
    {
        this.name = name;
        this.cost = cost;
    }
}

class Fireball : Spell
{
    public Fireball() : base("Fireball", 3) {}
}
