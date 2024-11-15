﻿namespace FrostFire.Engine;

public class Quest
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int RewardExperiencePoints { get; set; }
    public int RewardGold { get; set; }
    public List<QuestCompletionItem> QuestCompletionItems { get; set; }
    public Item RewardItem { get; set; }
    public Quest(int id, string name, string description, int expPoints, int gold)
    {
        ID = id;
        Name = name;
        Description = description;
        RewardExperiencePoints = expPoints;
        RewardGold = gold;
        QuestCompletionItems = new List<QuestCompletionItem>();
    }

}
