namespace FrostFire.Engine;

public class Player : LivingCreature
{
    public int Golds { get; set; }
    public int ExperiencePoints { get; set; }
    public int Level { get; set; }

    public Player(int currentHitPoints, int maxHitPoints, int golds, int expPoints, int level)
        :base(currentHitPoints, maxHitPoints)
    {
        Golds = golds;
        ExperiencePoints = expPoints;
        Level = level;
    }

}
