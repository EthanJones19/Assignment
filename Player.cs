using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.IO;
using System.Linq;

namespace HelloWorld
{
    class Player
    {
        protected float _playerHealth;
        protected string _playerName;
        protected float _playerDamage;
        protected int _playerMoney;
        protected float _playerSpeed;
        protected Item[] _inventory = new Item[4];
        protected Item _equipedWeapon = new Item("none ", 0, 0);
        protected Item _item1 = new Item("none ", 0, 0);
        protected Item _item2 = new Item("none ", 0, 0);
        protected Item _item3 = new Item("none ", 0, 0);
        protected Item _item4 = new Item("none ", 0, 0);




        //Player's nothing stats
        public Player()
        {
            _playerHealth = 100;
            _playerName = "Some Hobo";
            _playerDamage = 20;
            _playerSpeed = 50;
            _playerMoney = 5;

        }


        public Player(string nameVal, float healthVal, float damageVal, float speedVal, int moneyVal, int inventorySize)
        {
            _playerHealth = healthVal;
            _playerName = nameVal;
            _playerDamage = damageVal;
            _playerSpeed = speedVal;
            _playerMoney = moneyVal;
            _inventory = new Item[inventorySize];
            _inventory[0] = _item1;
            _inventory[1] = _item2;
            _inventory[2] = _item3;
            _inventory[3] = _item4;
        }
        //Constructor

        public void PlayerStats()
        {
            Console.WriteLine("Name: " + _playerName);
            Console.WriteLine("Life: " + _playerHealth);
            Console.WriteLine("Damage: " + _playerDamage);
            Console.WriteLine("Reaction Speed: " + _playerSpeed);
            Console.WriteLine("Coins: " + _playerMoney);
        }
        //Prints player stats


        public Item[] InventoryView()
        {
            return _inventory;
        }
        //Views player's inventory


        //Contains item function
        public bool Contain(int itemIndex)
        {
            if (itemIndex >= 0 && itemIndex < _inventory.Length)
            {
                return true;
            }
            return false;
        }

        //Equips item function
        public void EquipItem(int itemIndex)
        {
            if (Contain(itemIndex))
            {
                _playerDamage -= _equipedWeapon.statIncrease;
                _playerSpeed += _equipedWeapon.statIncrease;
                _equipedWeapon = _inventory[itemIndex];
                _playerSpeed -= _equipedWeapon.statIncrease;
                _playerDamage += _equipedWeapon.statIncrease;
            }

        }
        
        //Heals player to max health
        public void SpecialHealingBeer()
        {
            if (_playerHealth < MaxHealth())
            {
                _playerHealth = MaxHealth();
            }
        }

        //Player's max Health
        public float MaxHealth()
        {
            return 100;
        }

        //Gets player name for player
        public string GetPlayerName()
        {
            return _playerName;
        }
        //Player is alive function
        public bool PlayerAlive()
        {
            return _playerHealth > 0;
        }
        //Player is dead function
        public bool PlayerDead()
        {
            return _playerHealth <= 0;
        }
        //Attack function for player
        public virtual float Attack(Enemy enemy)
        {
            float damageTaken = enemy.TakenDamage(_playerDamage);
            return damageTaken;
        }
        //Player takes damage function
        public virtual float TakenDamage(float damageVal)
        {
            _playerHealth -= damageVal;
            if (_playerHealth < 0)
            {
                _playerHealth = 0;
            }
            return damageVal;
        }
        //Returns player speed
        public float PlayerSpeed()
        {
            return _playerSpeed;
        }
        //Player Buy function
        public void Buy(Item item, int inventoryIndex)
        {
            if (_playerMoney >= item.cost)
            {
                _playerMoney -= item.cost;

                _inventory[inventoryIndex] = item;
                Console.WriteLine("Item has been purchased.");
            }

            else
            {
                Console.WriteLine("You need more money to buy this item, chief.");

            }
        }
        //Get money function
        public int GetMoney()
        {
            return _playerMoney;
        }


        //Saves player's stats
        public virtual void Save(StreamWriter writer, int currentfight)
        {
            writer.WriteLine(_playerName);
            writer.WriteLine(_playerHealth);
            writer.WriteLine(_playerDamage);
            writer.WriteLine(_playerSpeed);
            writer.WriteLine(_playerMoney);

            foreach(Item item in _inventory)
            {
                writer.WriteLine(item.name);
                writer.WriteLine(item.statIncrease);
                writer.WriteLine(item.cost);
            }
            writer.WriteLine(currentfight);
        }
        //Loads player's stats
        public virtual bool Load(StreamReader reader, ref int currentfight)
        {
            string name = reader.ReadLine();
            float damage = 0;
            float health = 0;
            float speed = 0;
            int money = 0;
            if (float.TryParse(reader.ReadLine(), out health) == false)
            {
                return false;
            }
            if (float.TryParse(reader.ReadLine(), out damage) == false)
            {
                return false;
            }
            if (float.TryParse(reader.ReadLine(), out speed) == false)
            {
                return false;
            }
            if (int.TryParse(reader.ReadLine(), out money) == false)
            {
                return false;
            }
            _playerName = name;
            _playerDamage = damage;
            _playerHealth = health;
            _playerSpeed = speed;
            _playerMoney = money;
            for (int i = 0; i < _inventory.Count(); i++)
            {
                string itemName = reader.ReadLine();
                int.TryParse(reader.ReadLine(), out int itemStatIncrease);
                int.TryParse(reader.ReadLine(), out int itemCost);
                _inventory[i] = new Item(itemName, itemStatIncrease, itemCost);
            }
            int.TryParse(reader.ReadLine(), out currentfight);
            return true;
        }
        //Prize money function
        public void PrizeMoney()
        {
            if (_playerHealth > 0)
            {
                _playerMoney += 100;

            }
        }




    }

}
