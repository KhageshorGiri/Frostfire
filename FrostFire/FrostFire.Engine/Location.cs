namespace FrostFire.Engine;

public class Location
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Item? ItemRequiredToEnter { get; set; }
    public Quest? QuestionAvailableHere { get; set; }
    public Monster? MonsterLivingHere { get; set; }

    public Location(int id, string name, string description, 
        Item? itemRequiredToEnter = default, Quest? questionAvailableHere = default, Monster? monsterLivingHere = default)
    {
        ID = id;
        Name = name;
        Description = description;
        ItemRequiredToEnter = itemRequiredToEnter;
        QuestionAvailableHere = questionAvailableHere;
        MonsterLivingHere = monsterLivingHere;
    }
}
