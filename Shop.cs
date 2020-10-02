using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Shop
    {
        private Item[] _inventory = new Item[4];
        private int _playerMoney;
        protected Item _item1 = new Item("Golden Gun", 100, 100);
        protected Item _item2 = new Item("Golden Gun", 100, 100);
        protected Item _item3 = new Item("Golden Gun", 100, 100);
        protected Item _item4 = new Item("Golden Gun", 100, 100);

        public Shop()
        {
            _inventory[0] = _item1;
            _inventory[1] = _item2;
            _inventory[2] = _item3;
            _inventory[3] = _item4;
            _playerMoney = 0;

        }

        public Item[] GetInventory()
        {
            return _inventory;
        }
    }
}
