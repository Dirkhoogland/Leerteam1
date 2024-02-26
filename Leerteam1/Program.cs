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
            /*
            World.PopulateWeapons();
            World.PopulateMonsters();
            World.PopulateQuests();
            World.PopulateLocations();

            World.Print();
            Console.ReadLine();
            */
            Inventory playerInventory = new Inventory();
            playerInventory.AddInventoryItem(new Weapon(playerInventory.inventory.Count, "| Wooden sword  |", 2));
            playerInventory.AddInventoryItem(new Item(playerInventory.inventory.Count, "| String        |"));
            playerInventory.PrintInventory();
            Console.ReadLine();

            playerInventory.ChangeEquipedWeapon();
            playerInventory.PrintInventory();
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

