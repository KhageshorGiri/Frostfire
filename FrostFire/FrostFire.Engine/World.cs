﻿namespace FrostFire.Engine;

/// <summary>
/// This is class that holds every things for game
/// here, world means everything that we are using in our game.
/// </summary>
public static class World
{
    private static readonly List<Item> Items = new List<Item>();
    private static readonly List<Quest> Questions = new List<Quest>();
    public static readonly List<Location> Locations = new List<Location>(); 
    public static readonly List<Monster> Monsters = new List<Monster>();

    public const int ITEM_ID_RUSTY_SWORD = 1;
    public const int ITEM_ID_RAT_TAIL = 2;
    public const int ITEM_ID_PIECE_OF_FUR = 3;
    public const int ITEM_ID_SNAKE_FANG = 4;
    public const int ITEM_ID_SNAKESKIN = 5;
    public const int ITEM_ID_CLUB = 6;
    public const int ITEM_ID_HEALING_POTION = 7;
    public const int ITEM_ID_SPIDER_FANG = 8;
    public const int ITEM_ID_SPIDER_SILK = 9;
    public const int ITEM_ID_ADVENTURER_PASS = 10;

    public const int MONSTER_ID_RAT = 1;
    public const int MONSTER_ID_SNAKE = 2;
    public const int MONSTER_ID_GIANT_SPIDER = 3;

    public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
    public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;

    public const int LOCATION_ID_HOME = 1;
    public const int LOCATION_ID_TOWN_SQUARE = 2;
    public const int LOCATION_ID_GUARD_POST = 3;
    public const int LOCATION_ID_ALCHEMIST_HUT = 4;
    public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
    public const int LOCATION_ID_FARMHOUSE = 6;
    public const int LOCATION_ID_FARM_FIELD = 7;
    public const int LOCATION_ID_BRIDGE = 8;
    public const int LOCATION_ID_SPIDER_FIELD = 9;

    static World()
    {
        PopulateItems();
        PopulateMonsters();
        PopulateQuests();
        PopulateLocations();
    }

    public static void PopulateItems()
    {
        // Add Items
        Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails"));
        Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur"));
        Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake fangs"));
        Items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins"));
        Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider fang", "Spider fangs"));
        Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Spider silks"));
        Items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer pass", "Adventurer passes"));

        // Add Weapons
        Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", 0, 5));
        Items.Add(new Weapon(ITEM_ID_CLUB, "Club", "Clubs", 3, 10));

        // Add Healing Points
        Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Healing potion", "Healing potions", 5));
    }

    private static void PopulateMonsters()
    {
        Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3);
        rat.LootItems.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
        rat.LootItems.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

        Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3);
        snake.LootItems.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
        snake.LootItems.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, true));

        Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant spider", 20, 5, 40, 10, 10);
        giantSpider.LootItems.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
        giantSpider.LootItems.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));

        Monsters.Add(rat);
        Monsters.Add(snake);
        Monsters.Add(giantSpider);
    }

    private static void PopulateQuests()
    {
        Quest clearAlchemistGarden =
            new Quest(
                QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                "Clear the alchemist's garden",
                "Kill rats in the alchemist's garden and bring back 3 rat tails. You will receive a healing potion and 10 gold pieces.", 20, 10);

        clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));

        clearAlchemistGarden.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);

        Quest clearFarmersField =
            new Quest(
                QUEST_ID_CLEAR_FARMERS_FIELD,
                "Clear the farmer's field",
                "Kill snakes in the farmer's field and bring back 3 snake fangs. You will receive an adventurer's pass and 20 gold pieces.", 20, 20);

        clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 3));

        clearFarmersField.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);

        Questions.Add(clearAlchemistGarden);
        Questions.Add(clearFarmersField);
    }

    private static void PopulateLocations()
    {
        // Create each location
        Location home = new Location(LOCATION_ID_HOME, "Home", "Your house. You really need to clean up the place.");

        Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town square", "You see a fountain.");

        Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants on the shelves.");
        alchemistHut.QuestionAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

        Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's garden", "Many plants are growing here.");
        alchemistsGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);

        Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer in front.");
        farmhouse.QuestionAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

        Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's field", "You see rows of vegetables growing here.");
        farmersField.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

        Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post", "There is a large, tough-looking guard here.", ItemByID(ITEM_ID_ADVENTURER_PASS));

        Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.");

        Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "You see spider webs covering covering the trees in this forest.");
        spiderField.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);

        // Link the locations together
        home.LocationToNorth = townSquare;

        townSquare.LocationToNorth = alchemistHut;
        townSquare.LocationToSouth = home;
        townSquare.LocationToEast = guardPost;
        townSquare.LocationToWest = farmhouse;

        farmhouse.LocationToEast = townSquare;
        farmhouse.LocationToWest = farmersField;

        farmersField.LocationToEast = farmhouse;

        alchemistHut.LocationToSouth = townSquare;
        alchemistHut.LocationToNorth = alchemistsGarden;

        alchemistsGarden.LocationToSouth = alchemistHut;

        guardPost.LocationToEast = bridge;
        guardPost.LocationToWest = townSquare;

        bridge.LocationToWest = guardPost;
        bridge.LocationToEast = spiderField;

        spiderField.LocationToWest = bridge;

        // Add the locations to the static list
        Locations.Add(home);
        Locations.Add(townSquare);
        Locations.Add(guardPost);
        Locations.Add(alchemistHut);
        Locations.Add(alchemistsGarden);
        Locations.Add(farmhouse);
        Locations.Add(farmersField);
        Locations.Add(bridge);
        Locations.Add(spiderField);
    }

    public static Item ItemByID(int id)
    {
        foreach (Item item in Items)
        {
            if (item.ID == id)
            {
                return item;
            }
        }

        return null;
    }

    public static Monster MonsterByID(int id)
    {
        foreach (Monster monster in Monsters)
        {
            if (monster.ID == id)
            {
                return monster;
            }
        }

        return null;
    }

    public static Quest QuestByID(int id)
    {
        foreach (Quest quest in Questions)
        {
            if (quest.ID == id)
            {
                return quest;
            }
        }

        return null;
    }

    public static Location LocationByID(int id)
    {
        foreach (Location location in Locations)
        {
            if (location.ID == id)
            {
                return location;
            }
        }

        return null;
    }
}
