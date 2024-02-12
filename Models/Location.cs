namespace Models
{
    public class Location
    {
        //----- parameters -----//
        public int ID;
        public string Name;
        public string Description;
        public Quest? QuestAvailableHere;
        public Monster? MonsterLivingHere;

        //Mapping
        public Location? LocationToNorth;
        public Location? LocationToSouth;
        public Location? LocationToEast;
        public Location? LocationToWest;

        //----- Constructor -----//
        public Location(int iD, string name, string description, Quest? QuestAvailableHere, Monster? MonsterLivingHere)
        {
            ID = iD;
            Name = name;
            Description = description;
            this.QuestAvailableHere = QuestAvailableHere;
            this.MonsterLivingHere = MonsterLivingHere;
        }
    }
}
