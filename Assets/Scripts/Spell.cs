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
    string spriteName = "Fireball";

    public Fireball() : base("Fireball", 3) { }
}
