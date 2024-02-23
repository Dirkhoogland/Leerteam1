
namespace Models
{
    internal class Combat
    {   

        public void StartCombat(Player player, Monster monster)
        {
            int playerweapon = player.PlayerInventory.equipedWeapon.Damage;
            int monsterweapon = monster.MaximumDamage;
            int monsterdamage = 0;
            while (player.CurrentHitPoints > 0 && monster.CurrentHitPoints > 0)
            {
                Console.WriteLine("Chose an action, heal or attack");
                string input  = Console.ReadLine().ToLower(); 
                if(input == "attack")
                {
                    monster.CurrentHitPoints = AttackOpponent(playerweapon, monster.CurrentHitPoints);
                    Console.WriteLine($"You attacked the monster, you did {playerweapon} damage, it now has {monster.CurrentHitPoints} hp remaining");
                    player.CurrentHitPoints =  Attackmonster(monsterweapon, player.CurrentHitPoints);
                    Console.WriteLine($"The monster attacked you did {monsterdamage} damage, you now have {player.CurrentHitPoints} hp remaining");

                }
                else if (input == "heal")
                {
                    player.CurrentHitPoints = Healingplayer(player.CurrentHitPoints, player.MaximumHitPoints);
                    Console.WriteLine($"you healed 15 hp, you now have {player.CurrentHitPoints}");
                    player.CurrentHitPoints = Attackmonster(monsterweapon, player.CurrentHitPoints);
                    Console.WriteLine($"The monster attacked you did {monsterdamage} damage, you now have {player.CurrentHitPoints} hp remaining");

                }
                else
                {
                    Console.WriteLine("Invalid input");
                }



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
        public int Attackmonster(int damage, int hp)
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
