namespace Models
{
    public class Quest
    {
        //----- parameters -----//
        public int ID;
        public string Discription;
        public string Name;

        //----- Constructor -----//
        public Quest(int iD, string discription, string name)
        {
            this.ID = iD;
            this.Discription = discription;
            this.Name = name;
        }
    }
}
