namespace Models
{
    public class Monster
    {
        //----- parameters -----//
        public int CurrentHitPoints;
        public int ID;
        public int MaximumDamage;
        public int MaximumHitPoints;
        public string Name;

        //----- Constructor -----//
        public Monster(int iD, string name, int currentHitPoints, int maximumDamage, int maximumHitPoints)
        {
            this.CurrentHitPoints = currentHitPoints;
            this.ID = iD;
            this.MaximumDamage = maximumDamage;
            this.MaximumHitPoints = maximumHitPoints;
            this.Name = name;
        }
    }
}
