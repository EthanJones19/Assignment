using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Shop
    {
         
        public Item[] inventory = new Item[4];
        protected Item _item1 = new Item("Golden Gun ", 100, 100);
        protected Item _item2 = new Item("SteelChair ", 80, 80);
        protected Item _item3 = new Item("Gun ", 30, 50);
        protected Item _item4 = new Item("Rifle ", 50, 60);

        public Shop()//Shows shop's items
        {
            inventory[0] = _item1;
            inventory[1] = _item2;
            inventory[2] = _item3;
            inventory[3] = _item4;

        }

        

        public Item[] GetShopInventory()//Gets shop's inventory
        {
            return inventory;
        }
    }
}
