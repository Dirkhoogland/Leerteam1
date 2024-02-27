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
            //Create player for later use and setting up a invetory
            Player player = new Player(25, 0, 25, "test");
            player.PlayerInventory.AddInventoryItem(new Weapon(player.PlayerInventory.inventory.Count, "| Wooden sword  |", 2));
            player.PlayerInventory.AddInventoryItem(new Item(player.PlayerInventory.inventory.Count, "| String        |"));
            player.PlayerInventory.AddInventoryItem(new Item(player.PlayerInventory.inventory.Count, "| Gold pouch    |"));

            //Making a | Main menu | and drawing it
            InputMenu menu = new InputMenu("| Main menu |", true);
            menu.Add("Inventory", (x) =>
            {
                //Create inventory functions and print function
                Console.Clear();
                player.PlayerInventory.PrintInventory();
                Console.ReadLine();
            });
            menu.Add("Equip Weapon", (x) =>
            {
                Console.Clear();
                player.PlayerInventory.ChangeEquipedWeapon();
                player.PlayerInventory.PrintInventory();
                Console.ReadLine();
            });
            menu.Add("Pause", (x) =>
            {
                Pause();
            });
            menu.Add("Location", (x) =>
            {
                Console.Clear();
                InputMenu weaponMenu = new InputMenu("| Locations |");
                foreach (var location in World.Locations)
                {
                    weaponMenu.Add(location.Name, (x) =>
                    {
                        Console.Clear();
                        Console.WriteLine($"{location.Name} (X: {location.X}, Y: {location.Y})");
                        Console.ReadLine();
                    });

                }
                weaponMenu.UseMenu();
            });
            menu.Add("Gold", (x) =>
            {
                Console.Clear();
                InputMenu weaponmenu = new InputMenu("| Gold amount |");
                Console.WriteLine("The gold that you received from monster is " + Gold.goldCount);
                Console.ReadLine();
                weaponmenu.UseMenu();
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

