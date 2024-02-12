using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
using Menu;

namespace Leerteam1
{
    internal class Program
    {
        static void Main()
        {
            World.PopulateWeapons();
            World.PopulateMonsters();
            World.PopulateQuests();
            World.PopulateLocations();

            World.Print();
            Console.ReadLine();

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
    }
}

