using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Hobo
    {
        private Item _dustyClothes;
        private Item _stick;
        private Item[] _inventory;


        public Hobo()
        {
            _inventory = new Item[3];
            _stick.name = "Stick";
            _stick.statIncrease = 0;
            _dustyClothes.name = "Dusty Clothes";
            _dustyClothes.statIncrease = 0;
        }
        
        
        public Hobo(string nameVal,float healthVal, float damageVal, int inventorySize)
        {
            _inventory = new Item[3];
            _stick.name = "Stick";
            _stick.statIncrease = 0;
            _dustyClothes.name = "Dusty Clothes";
            _dustyClothes.statIncrease = 0;
        }

        public void AddInventory(Item item, int index)
        {
            _inventory[index] = item;
        }

        public Item[] InventoryView()
        {
            return _inventory;
        }

        public bool Contain(int itemIndex)
        {
            if (itemIndex > 0 && itemIndex < _inventory.Length)
            {
                return true;
            }
            return false;
        }



    }
}
