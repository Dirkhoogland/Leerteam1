namespace Models
{
    public class Weapon
    {
        //----- parameters -----//
        public int ID;
        public string Name;
        public int Damage;

        //----- Constructor -----//
        public Weapon(int iD, string name, int damage)
        {
            ID = iD;
            Name = name;
            Damage = damage;
        }
    }
}
