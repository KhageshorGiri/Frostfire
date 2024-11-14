
namespace FrostFire.Engine;

public class LivingCreature
{
    public int CurrentHitPoints { get; set; }
    public int MaximumHitPoints { get; set; }

    public LivingCreature(int currentHitPoints, int maxHitPoints)
    {
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maxHitPoints;
    }
}
