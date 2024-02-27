namespace Models
{
    public static class World
    {
        
        //----- Creating object-instances -----//
        public static readonly List<Weapon> Weapons = new List<Weapon>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();
        public static readonly Random RandomGenerator = new Random();

        //----- Object specifics -----//
        //Weapon
        public const int WEAPON_ID_RUSTY_SWORD = 1;
        public const int WEAPON_ID_CLUB = 2;
        
        //Monster
        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;

        //Quest
        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;
        public const int QUEST_ID_COLLECT_SPIDER_SILK = 3;

        //Location
        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;

        //----- Methods -----//
        static World()
        {
            PopulateWeapons();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        //----- General setup methods -----//
        //Weapons
        public static void PopulateWeapons()
        {
            Weapons.Add(new Weapon(WEAPON_ID_RUSTY_SWORD, "Rusty sword", 5));
            Weapons.Add(new Weapon(WEAPON_ID_CLUB, "Club", 10));
        }

        //Monsters
        public static void PopulateMonsters()
        {
            
            Monster rat = new Monster(MONSTER_ID_RAT, "rat", 3, 3, 3);
            Monster snake = new Monster(MONSTER_ID_SNAKE, "snake", 10, 7, 7);
            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "giant spider", 3, 10, 10);


            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
        }

        //Quests
        public static void PopulateQuests()
        {
            Quest clearAlchemistGarden =
                new Quest(
                    QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                    "Clear the alchemist's garden",
                    "Kill rats in the alchemist's garden ");



            Quest clearFarmersField =
                new Quest(
                    QUEST_ID_CLEAR_FARMERS_FIELD,
                    "Clear the farmer's field",
                    "Kill snakes in the farmer's field");


            Quest clearSpidersForest =
                        new Quest(
                            QUEST_ID_COLLECT_SPIDER_SILK,
                            "Collect spider silk",
                            "Kill spiders in the spider forest");


            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
            Quests.Add(clearSpidersForest);
        }

        //Locations
        public static void PopulateLocations()
        {
            // Create each location
        Location home = new Location(LOCATION_ID_HOME, "Home", "Your house. You really need to clean up the place.", null, null)
        {
            X = 0,
            Y = 0
        };

        Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town square", "You see a fountain.", null, null)
        {
            X = 0,
            Y = 1
        };

        Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants on the shelves.", null, null)
        {
            X = 0,
            Y = 2
        };
        alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

        Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's garden", "Many plants are growing here.", null, null)
        {
            X = 0,
            Y = 3
        };
        alchemistsGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);

        Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer in front.", null, null)
        {
            X = -1,
            Y = 1
        };
        farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

        Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's field", "You see rows of vegetables growing here.", null, null)
        {
            X = -2,
            Y = 1
        };
        farmersField.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

        Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post", "There is a large, tough-looking guard here.", null, null)
        {
            X = 1,
            Y = 1
        };

        Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.", null, null)
        {
            X = 2,
            Y = 1
        };
        bridge.QuestAvailableHere = QuestByID(QUEST_ID_COLLECT_SPIDER_SILK);

        Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "You see spider webs covering covering the trees in this forest.", null, null)
        {
            X = 3,
            Y = 1
        };
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

        //----- Identification methods -----//
        //Location
        public static Location? LocationByID(int id)
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

        //Weapon
        public static Weapon? WeaponByID(int id)
        {
            foreach (Weapon item in Weapons)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        //Monster
        public static Monster? MonsterByID(int id)
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

        //Quest
        public static Quest? QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }

        //Printing Saved/Created Data
        public static void Print()
        {
            foreach (Weapon weapen in Weapons)
            {
                Console.WriteLine(weapen.Type);
            }
            foreach (Monster monster in Monsters)
            {
                Console.WriteLine(monster.Name);
            }
            foreach (Quest quest in Quests)
            {
                Console.WriteLine(quest.Name);
            }
            foreach (Location location in Locations)
            {
                Console.WriteLine(location.Name);
            }
        }
    }
}
