using System.Collections.Generic;

public class Soul
{
    public string soulName;
    public string description;
    public int level;
    // public int x = -1
    // public int y = -1;
    public List<Spell> spells = new List<Spell>(5);
}

public class Spell
{
    public string name;
    public Dictionary<string, int> vals;
}
