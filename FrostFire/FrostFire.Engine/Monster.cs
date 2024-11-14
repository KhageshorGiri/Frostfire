
namespace FrostFire.Engine;

public class Monster : LivingCreature
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int MaximumDamage { get; set; }
    public int RewardExperiencePoints { get; set; }
    public int RewardGold { get; set; }
    public List<LootItem> LootItems { get; set; }
    public Monster(int id, string name, int currentHitPoints, int maxHitPoints, int maxDamage, int expPoints, int rewardGold)
        : base(currentHitPoints, maxHitPoints)
    {
        ID = id;
        Name = name;
        MaximumDamage = maxDamage;
        RewardExperiencePoints = expPoints;
        RewardGold = rewardGold;
        LootItems = new List<LootItem>();
    }
}
