namespace Models
{
    public class SuperAdventure
    {
        //----- parameters -----//
        public int CurrentMonster;
        public string ThePlayer;

        //----- Constructor -----//
        public SuperAdventure(int currentMonster, string thePlayer)
        {
            this.CurrentMonster = currentMonster;
            this.ThePlayer = thePlayer;
        }
    }
}
