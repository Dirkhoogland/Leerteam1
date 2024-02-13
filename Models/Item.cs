using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Item
    {
        //----- parameters -----//
        public int ID;
        public string Type;
        public string Description;

        //----- Constructor -----//
        public Item(int id, string type, string description = "")
        {
            this.ID = id;
            this.Type = type;
            this.Description = description;
        }
    }
}
