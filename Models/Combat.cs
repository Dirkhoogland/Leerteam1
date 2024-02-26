
namespace Models
{
    public class Combat
    {   

        public static void StartCombat(Player player, Monster monster)
        {
            Console.Clear();
            int playerweapon = player.PlayerInventory.equipedWeapon.Damage;
            int monsterweapon = monster.MaximumDamage;
            Console.WriteLine($"You found a {monster.Name}");
            while (player.CurrentHitPoints > 0 && monster.CurrentHitPoints > 0)
            {
                Console.WriteLine("Chose an action, heal or attack");
                string input  = Console.ReadLine().ToLower(); 
                if(input == "attack")
                {
                    monster.CurrentHitPoints = AttackOpponent(playerweapon, monster.CurrentHitPoints);
                    Console.WriteLine($"You attacked the monster, you did {playerweapon} damage, it now has {monster.CurrentHitPoints} hp remaining");
                    player.CurrentHitPoints =  Attackmonster(monsterweapon, player.CurrentHitPoints);
                    Console.WriteLine($"The monster attacked you did {monsterweapon} damage, you now have {player.CurrentHitPoints} hp remaining");

                }
                else if (input == "heal")
                {
                    player.CurrentHitPoints = Healingplayer(player.CurrentHitPoints, player.MaximumHitPoints);
                    Console.WriteLine($"you healed 15 hp, you now have {player.CurrentHitPoints}");
                    player.CurrentHitPoints = Attackmonster(monsterweapon, player.CurrentHitPoints);
                    Console.WriteLine($"The monster attacked you did {monsterweapon} damage, you now have {player.CurrentHitPoints} hp remaining");

                }
                else
                {
                    Console.WriteLine("Invalid input");
                }



            }
            if (player.CurrentHitPoints <= 0)
            {
                Defeat(player);
            }
            else
            {
                Victory(player);
            }
        }
        

        public static int AttackOpponent(int damage, int hp)
        {
            hp -= damage;
            if (hp > 0)
            {
                return hp;
            }
            else 
            { 
                return 0;
            }
        }
        public static  int Attackmonster(int damage, int hp)
        {
            hp -= damage;
            if (hp > 0)
            {
                return hp;
            }
            else
            {
                return 0;
            }
        }
        public static void Victory(Player player)
        {
            player.CurrentHitPoints = 25;
            Console.WriteLine("You won the combat");
            
            Console.ReadLine();
        }

        public static void Defeat(Player player)
        {
            player.CurrentHitPoints = 25;
            Console.WriteLine("You lost the combat");
            Console.ReadLine();
        }

        public static int Healingplayer(int hp, int maxhp)
        {
            hp += 15;
            if(hp > maxhp) hp = maxhp;


            return hp;
        }

    }
}
