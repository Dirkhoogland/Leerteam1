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
            Weapon playerweapon = World.Weapons.id([player.CurrentWeapon]);
            while(player.CurrentHitPoints > 0 && monster.CurrentHitPoints > 0)
            {
                
            }
            if (player.CurrentHitPoints <= 0)
            {
                Defeat();
            }
            else
            {
                Victory();
            }
        }
        

        public int AttackOpponent(int damage, int hp)
        {
            hp -= damage;
            if (hp > 0)
            {
                return hp;
            }
            else 
            { 
                return hp;
            }
        }
        public void Victory()
        {
            Console.WriteLine("You won the combat");
        }

        public void Defeat()
        {
            Console.WriteLine("You lost the combat");
        }

        public int Healingplayer(int hp, int maxhp)
        {
            hp += 15;
            if(hp > maxhp) hp = maxhp;


            return hp;
        }

    }
}
