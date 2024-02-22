using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Functions
{
    internal class Combat
    {
        public void StartCombat(Player player, Monster monster)
        {
            
        }


        public int AttackOpponent(int damage, int hp)
        {
            return hp;
        }

        public void Defeat()
        {

        }

        public int Healingplayer(int hp, int maxhp)
        {
            hp += 15;
            if(hp > maxhp) hp = maxhp;


            return hp;
        }

    }
}
