using System.Collections.Generic;

public class Soul
{
    public string soulName;
    public string description;
    public int level;
    public int x = -1;
    public int y = -1;
    public List<string> direction = new List<string>() { "U1", "D1", "L1", "R1", "UL1", "UR1", "DL1", "UR1" };
    public List<Spell> spells = new List<Spell>(5);
}
