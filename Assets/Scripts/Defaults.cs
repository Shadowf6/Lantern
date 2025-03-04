public class Defaults
{
    public static Soul MakeSoul(string name)
    {
        switch (name)
        {
            case "Lantern":
                return new Soul { soulName = "Lantern", description = "", level = 1, spells = { MakeSpell("Fireball") } };
        }

        return null;
    } 

    public static Spell MakeSpell(string name)
    {
        switch (name)
        {
            case "Fireball":
                return new Fireball();
        }

        return null;
    }
}
