namespace Models
{
    public class Weapon: Item
    {
        //----- parameters -----//
        public int Damage;

        //----- Constructor -----//
        public Weapon(int id, string type, int damage) : base(id, type)
        {
            this.Damage = damage;
        }
    }
}
