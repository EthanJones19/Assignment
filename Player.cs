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
        protected int _playerMoney;
        protected float _playerSpeed;
        protected Item[] _inventory = new Item[4];
        protected Item _equipedWeapon = new Item("none ", 0, 0);
        protected Item _item1 = new Item("none ", 0, 0);
        protected Item _item2 = new Item("none ", 0, 0);
        protected Item _item3 = new Item("none ", 0, 0);
        protected Item _item4 = new Item("none ", 0, 0);





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

        public void PlayerStats()
        {
            Console.WriteLine("Name: " + _playerName);
            Console.WriteLine("Life: " + _playerHealth);
            Console.WriteLine("Damage: " + _playerDamage);
            Console.WriteLine("Reaction Speed: " + _playerSpeed);
            Console.WriteLine("Coins: " + _playerMoney);
        }



        public Item[] InventoryView()
        {
            return _inventory;
        }




        public bool Contain(int itemIndex)
        {
            if (itemIndex >= 0 && itemIndex < _inventory.Length)
            {
                return true;
            }
            return false;
        }

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
        
        public void SpecialHealingBeer()
        {
            if (_playerHealth < MaxHealth())
            {
                _playerHealth = MaxHealth();
            }
        }

        public float MaxHealth()
        {
            return 100;
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
            return _playerHealth <= 0;
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

        public float PlayerSpeed()
        {
            return _playerSpeed;
        }

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

        public int GetMoney()
        {
            return _playerMoney;
        }



        public virtual void Save(StreamWriter writer)
        {
            writer.WriteLine(_playerName);
            writer.WriteLine(_playerHealth);
            writer.WriteLine(_playerDamage);
            writer.WriteLine(_playerSpeed);
            writer.WriteLine(_playerSpeed);
        }

        public virtual bool Load(StreamReader reader)
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
            _playerName = name;
            _playerDamage = damage;
            _playerHealth = health;
            _playerSpeed = speed;
            _playerMoney = money;
            return true;
        }

        public void PrizeMoney()
        {
            if (_playerHealth > 0)
            {
                _playerMoney += 100;

            }
        }




    }

}
