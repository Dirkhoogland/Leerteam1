namespace Models
{
    public class Player
    {
        //----- parameters -----//
        public int CurrentHitPoints;
        public int CurrentLocation;
        public int CurrentWeapon;
        public Inventory PlayerInventory;
        public int MaximumHitPoints;
        public string Name;

        //----- Constructor -----//
        public Player(int currentHitPoints, int currentLocation, int maximumHitPoints, string name)
        {
            this.CurrentHitPoints = currentHitPoints;
            this.CurrentLocation = currentLocation;
            this.PlayerInventory = new Inventory();
            this.MaximumHitPoints = maximumHitPoints;
            this.Name = name;
        }
    }
}
