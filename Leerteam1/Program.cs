using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Leerteam1
{
    internal class Program
    {
        public static void Main()
        {
            /*
            World.PopulateWeapons();
            World.PopulateMonsters();
            World.PopulateQuests();
            World.PopulateLocations();

            World.Print();
            Console.ReadLine();
            */
            Player player = new Player(25, 0, 25, "test");
            //Inventory playerInventory = new Inventory();
            player.PlayerInventory.AddInventoryItem(new Weapon(player.PlayerInventory.inventory.Count, "| Wooden sword  |", 2));
            player.PlayerInventory.AddInventoryItem(new Item(player.PlayerInventory.inventory.Count, "| String        |"));
            player.PlayerInventory.PrintInventory();
            Console.ReadLine();

            player.PlayerInventory.ChangeEquipedWeapon();
            player.PlayerInventory.PrintInventory();
            Console.ReadLine();

            //Create inventory functions and print function

            //Pause();

            //Making a | Main menu | and drawing it
            InputMenu menu = new InputMenu("| Main menu |", true);
            menu.Add("Play", (x) =>
            {
            InputMenu playmenu = new InputMenu("| Play menu |");
            playmenu.Add("Yellow", (x) => { Console.ForegroundColor = ConsoleColor.Yellow; });
            playmenu.Add("Green", (x) => { Console.ForegroundColor = ConsoleColor.Green; });
            playmenu.UseMenu();
            });
            menu.Add("Options", (x) =>
            {
            InputMenu playmenu = new InputMenu("| Options |");
            playmenu.Add("fullscreen", (x) => { Console.WriteLine(""); });
            playmenu.Add("not fullscreen", (x) => { Console.WriteLine(""); });
            playmenu.UseMenu();
            });
            menu.Add("Combat", (x) =>
            {
                
                InputMenu playmenu = new InputMenu("| Options |");
                playmenu.Add("Rat", (x) => { Combat.StartCombat(player, World.Monsters[0]); });
                playmenu.Add("Snake", (x) => { Combat.StartCombat(player, World.Monsters[1]); });
                playmenu.Add("GiantSpider", (x) => { Combat.StartCombat(player, World.Monsters[2]); });
                playmenu.UseMenu();
            });

            menu.UseMenu();
        }
        public static void Pause()
        {
            //Making a quit menu and drawing it
            InputMenu menu = new InputMenu("| Are you sure you want to quit? |");
            menu.Add("Quit", (x) => {
                Environment.Exit(0);
            });
            menu.UseMenu();
        }
    }
}

