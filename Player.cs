using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.IO;


namespace HelloWorld
{
    class Player
    {
        protected float _playerHealth;
        protected string _playerName;
        protected float _playerDamage;
        protected float _playerSpeed;
        protected float _money;
        protected Item[] _inventory = new Item[4];
        protected Item _equipedWeapon = new Item("stick", 10);
        protected Item _item1 = new Item("Gun", 30);
        protected Item _item2 = new Item("Rifle", 50);
        protected Item _item3 = new Item("Golden Gun", 70);
        protected Item _item4 = new Item("Steel Chair", 90);





        public Player()
        {
            _playerHealth = 100;
            _playerName = "Some Hobo";
            _playerDamage = 20;
            _playerSpeed = 50;
            _inventory[0] = _item1;
            _inventory[1] = _item2;
            _inventory[2] = _item3;
            _inventory[3] = _item4;

        }


        public Player(string nameVal, float healthVal, float damageVal, float speedVal, int inventorySize)
        {
            _playerHealth = healthVal;
            _playerName = nameVal;
            _playerDamage = damageVal;
            _playerSpeed = speedVal;
            _inventory = new Item[inventorySize];
        }

        public void PlayerStats()
        {
            Console.WriteLine("Name: " + _playerName);
            Console.WriteLine("Life: " + _playerHealth);
            Console.WriteLine("Damage: " + _playerDamage);
            Console.WriteLine("Reaction Speed: " + _playerSpeed);
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

        public void EquipItem(int itemIndex)
        {
            if (Contain(itemIndex))
            {
                _playerSpeed -= _equipedWeapon.statIncrease;
                _equipedWeapon = _inventory[itemIndex];
                _playerSpeed += _equipedWeapon.statIncrease;
            }

        }


        

        public Item[] EnterInventory()
        {
            return _inventory;
        }

        public string GetPlayerName()
        {
            return _playerName;
        }

        public bool PlayerAlive()
        {
            return _playerHealth > 0;
        }

        public bool PlayerDead()
        {
            return _playerHealth < 0;
        }

        public virtual float Attack(Enemy enemy)
        {
            float damageTaken = enemy.TakenDamage(_playerDamage);
            return damageTaken;
        }

        public virtual float TakenDamage(float damageVal)
        {
            _playerHealth -= damageVal;
            if (_playerHealth < 0)
            {
                _playerHealth = 0;
            }
            return damageVal;
        }

        public virtual bool FasterSpeed(float speedVal)
        {
            return _playerSpeed >= speedVal;
        }

        public virtual void Save(StreamWriter writer)
        {
            //Save the characters stats
            writer.WriteLine(_playerName);
            writer.WriteLine(_playerHealth);
            writer.WriteLine(_playerDamage);
            writer.WriteLine(_playerSpeed);
        }

        public virtual bool Load(StreamReader reader)
        {
            //Create variables to store loaded data.
            string name = reader.ReadLine();
            float damage = 0;
            float health = 0;
            float speed = 0;
            //Checks to see if loading was successful.
            if (float.TryParse(reader.ReadLine(), out health) == false)
            {
                return false;
            }
            if (float.TryParse(reader.ReadLine(), out damage) == false)
            {
                return false;
            }
            //If successful, set update the member variables and return true.
            _playerName = name;
            _playerDamage = damage;
            _playerHealth = health;
            _playerSpeed = speed;
            return true;
        }

    }

    
}
