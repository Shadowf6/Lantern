using System.Collections.Generic;

public class Defaults
{
    public static Soul MakeSoul(string name)
    {
        Dictionary<string, Soul> defaultSouls = new Dictionary<string, Soul>()
        {
            {"Lantern",new Soul{soulName="Lantern",description="",level=0,spells={MakeSpell("fireball")}}}
        };

        return defaultSouls[name];
    } 

    public static Spell MakeSpell(string name)
    {
        Dictionary<string, Spell> defaultSpells = new Dictionary<string, Spell>()
        {
            {"Fireball",new Spell{name="Fireball1",vals={{"damage",15},{"cost",3}}}}
        };

        return defaultSpells[name];
    }
}
