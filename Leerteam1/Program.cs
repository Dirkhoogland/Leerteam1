using System;
using System.Collections.Generic;
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
            World.PopulateWeapons();
            World.PopulateMonsters();
            World.PopulateQuests();
            World.PopulateLocations();

            World.Print();
            Console.ReadLine();

            //Create inventory for later use
            Inventory playerInventory = new Inventory();

            //Making a | Main menu | and drawing it
            InputMenu menu = new InputMenu("| Main menu |", true);
            menu.Add("Inventory", (x) =>
            {
                //Create inventory functions and print function
                Console.Clear();
                playerInventory.AddInventoryItem(new Weapon(playerInventory.inventory.Count, "| Wooden sword  |", 2));
                playerInventory.AddInventoryItem(new Item(playerInventory.inventory.Count, "| String        |"));
                playerInventory.PrintInventory();
                Console.ReadLine();
            });
            menu.Add("Equip Weapon", (x) =>
            {
                Console.Clear();
                playerInventory.ChangeEquipedWeapon();
                playerInventory.PrintInventory();
                Console.ReadLine();
            });
            menu.Add("Pause", (x) =>
            {
                Pause();
            });
            menu.Add("Location", (x) =>
            {
                Console.Clear();
                foreach (var location in World.Locations)
                {
                    Console.WriteLine(location.Name);
                }
                Console.ReadLine();
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

