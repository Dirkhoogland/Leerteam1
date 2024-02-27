// User Story 1: As player I want to be able to move around the map to see different locations.
// Task: Options of moving locations.
// Acceptance Criteria: A menu that asks you which direction you want to go to.

// User Story 2: As a player I want to see where I can move on the map so I can decide where to move to.
// Task: A map of locations.
// Acceptance Criteria: The ability that lets you open up a map that displays where you are on the world map and where you can move to.
﻿namespace Models
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
        public int X { get; set; }
        public int Y { get; set; }

        //----- Constructor -----//
        public Location(int iD, string name, string description, Quest? QuestAvailableHere, Monster? MonsterLivingHere)
        {
            ID = iD;
            Name = name;
            Description = description;
            this.QuestAvailableHere = QuestAvailableHere;
            this.MonsterLivingHere = MonsterLivingHere;
        }
        public bool IsNorthBlocked { get; set; }
        public bool IsSouthBlocked { get; set; }
        public bool IsEastBlocked { get; set; }
        public bool IsWestBlocked { get; set; }
    // Objecten bij world.cs toevoegen en als er een object is dan Is(Richting)Blocked = true
    int Location_x = 0;
    int Location_y = 0;
    public Location MoveTo(string direction)
    {
        switch (direction.ToLower())
        {
            case "north":
                if (IsNorthBlocked)
                    throw new Exception("The path to the north is blocked.");
                LocationToNorth.PrintCurrentLocation();
                Location_y++;
                Console.WriteLine($"X: {Location_x}, Y: {Location_y}");
                return LocationToNorth;
            case "south":
                if (IsSouthBlocked)
                    throw new Exception("The path to the south is blocked.");
                LocationToSouth.PrintCurrentLocation();
                Location_y--;
                Console.WriteLine($"X: {Location_x}, Y: {Location_y}");
                return LocationToSouth;
            case "east":
                if (IsEastBlocked)
                    throw new Exception("The path to the east is blocked.");
                LocationToEast.PrintCurrentLocation();
                Location_x++;
                Console.WriteLine($"X: {Location_x}, Y: {Location_y}");
                return LocationToEast;
            case "west":
                if (IsWestBlocked)
                    throw new Exception("The path to the west is blocked.");
                LocationToWest.PrintCurrentLocation();
                Location_x--;
                Console.WriteLine($"X: {Location_x}, Y: {Location_y}");
                return LocationToWest;
            default:
                throw new Exception("Invalid direction. Please enter north, south, east, or west.");
        }
    }
// Map toevoegen om te kijken waar je bent. In samenwerking met locatie namen, dus als je bij locatie 1 bent dan is het locatie 1.
        public List<string> GetAvailableMoves()
        {
            List<string> availableMoves = new List<string>();

            if (LocationToNorth != null && !IsNorthBlocked)
            {
                availableMoves.Add("North");
            }

            if (LocationToSouth != null && !IsSouthBlocked)
            {
                availableMoves.Add("South");
            }

            if (LocationToEast != null && !IsEastBlocked)
            {
                availableMoves.Add("East");
            }

            if (LocationToWest != null && !IsWestBlocked)
            {
                availableMoves.Add("West");
            }

            return availableMoves;
        }
    public void PrintCurrentLocation()
    {
        Console.WriteLine($"You are currently at {Name}");
    }
    }
}