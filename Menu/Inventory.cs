using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Models;

namespace Functions
{
    public class Inventory
    {
        public List<Item> inventory;
        Dictionary<string, int> toPrint;
        public Weapon equipedWeapon = new Weapon(0, "", 0);
        public Inventory()
        {
            inventory = new List<Item>();
            toPrint = new Dictionary<string, int>();
            UpdatetoPrint();
        }
        public void ChangeEquipedWeapon()
        {
            InputMenu weaponMenu = new InputMenu("| Select a weapon and \"Continue\"|");
            foreach (Weapon item in getWeapons())
            {
                weaponMenu.Add(item.Type, (x) =>
                {
                    equipedWeapon = item;
                });
            }
            weaponMenu.UseMenu();
        }
        List<Item> getWeapons()
        {
            List<Item> toReturn = new List<Item>();
            foreach (Item item in inventory)
            {
                if (item.Type.Contains("sword"))
                {
                    toReturn.Add(item);
                }
            }
            return toReturn;
        }
        public void PrintInventory(bool weapon = false)
        {
            if (weapon) { UpdatetoPrint(weapon);}
            List<string> stringToPrint = new List<string>();
            if (equipedWeapon.Type.Length > 3) stringToPrint.Add(($"|Equiped: {equipedWeapon.Type.Substring(2)}            ").Substring(0, 22) + "|");
            else stringToPrint.Add(($"|Equiped: {equipedWeapon.Type}            ").Substring(0, 22) + "|");
            foreach (KeyValuePair<string, int> item in toPrint)
            {
                string inventoryStart = ((item.Value).ToString().Length == 1) ? "|  " : "| ";
                stringToPrint.Add($"{inventoryStart} {item.Value} {item.Key}");
            }
            Console.WriteLine("|      Inventory      |\n=======================");
            foreach (string item in stringToPrint)
            {
                Console.WriteLine(item);
            }
        }
        public void UpdatetoPrint(bool weapon = false)
        {
            toPrint = new Dictionary<string, int>();
            foreach (Item item in (weapon) ? getWeapons() : inventory)
            {
                if (!toPrint.ContainsKey(item.Type)) { toPrint.Add(item.Type, 1); }
                else { toPrint[item.Type] += 1; }
            }
        }
        public void AddInventoryItem(Item item)
        {
            inventory.Add(item);
            UpdatetoPrint();
        }
        public void RemoveInventoryItem(Item item)
        {
            inventory.Remove(item);
            UpdatetoPrint();
        }
    }
}
