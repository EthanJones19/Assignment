using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private float _playerHealth;
        private string _playerName;
        private float _playerDamage;
        private Item[] _inventory;

        public Player()
        {
            _playerHealth = 100;
            _playerName = "Some Hobo";
            _playerDamage = 20;
            _inventory = new Item[3];

        }

        public Player(float healthVal, string nameVal, float damageVal)
        {
            _playerHealth = healthVal;
            _playerName = nameVal;
            _playerDamage = damageVal;
        }

        public void PrintStats()
        {
            Console.WriteLine("Name: " + _playerName);
            Console.WriteLine("Health: " + _playerHealth);
            Console.WriteLine("Damage: " + _playerDamage);
        }

        public string GetName()
        {
            return _playerName;
        }

        public bool Alive()
        {
            return _playerHealth > 0;
        }


    }

    
}
