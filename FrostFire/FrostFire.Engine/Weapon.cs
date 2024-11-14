namespace FrostFire.Engine;

public class Weapon : Item
{
    public int MinimumDamage { get; set; }
    public int MaximumDamage { get; set; }

    public Weapon(int id, string name, string pluralName, int minDamage, int maxDamage)
        :base(id, name, pluralName)
    {
        MinimumDamage = minDamage;
        MaximumDamage = maxDamage;
    }
}
