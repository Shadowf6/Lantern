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

class BucklerShield : Spell{ public BucklerShield(): base("BucklerShield", 0) { } }
class EnergyShield : Spell { public EnergyShield() : base("EnergyShield", 0) { } }
class IronShield : Spell { public IronShield() : base("IronShield", 0) { } }
class Fireball : Spell { public Fireball() : base("Fireball", 0) {} }
class FireRain : Spell { public FireRain() : base("FireRain", 0) { } }
class FireWall : Spell { public FireWall() : base("FireWall", 0) { } }
class IceBeam : Spell { public IceBeam() : base("IceBeam", 0) { } }
class IceBolt : Spell { public IceBolt() : base("IceBolt", 0) { } }
class IceSpikes : Spell { public IceSpikes() : base("IceSpikes", 0) { } }
class IceWall : Spell { public IceWall() : base("IceWall", 0) { } }
class Lightning : Spell { public Lightning() : base("Lightning", 0) { } }
class MagicBolt : Spell { public MagicBolt() : base("MagicBolt", 0) { } }
class MagicMissile : Spell { public MagicMissile() : base("MagicMissile", 0) { } }
class PoisonBolt : Spell { public PoisonBolt() : base("PoisonBolt", 0) { } }
class PoisonIvy : Spell { public PoisonIvy() : base("PoisonIvy", 0) { } }
class ToxicBolt : Spell { public ToxicBolt() : base("ToxicBolt", 0) { } }
class PommelStrike : Spell { public PommelStrike() : base("PommelStrike", 0) { } }
class Arrow : Spell { public Arrow() : base("Arrow", 0) { } }
class FireArrow : Spell { public FireArrow() : base("FireArrow", 0) { } }
class GrappleArrow : Spell { public GrappleArrow() : base("GrappleArrow", 0) { } } // Will have special properties
class IceArrow : Spell { public IceArrow() : base("IceArrow", 0) { } }