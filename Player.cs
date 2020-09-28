using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HelloWorld
{
    class Player : Item
    {
        private float _health;
        private string _name;
        private float _damage;
        private Item[] _inventory;

        public Player()
        {
            _health = 100;
            _name = "Some Hobo";
            _damage = 20;
            _inventory = new Item[3];
        }

        public Player(float healthVal, string nameVal, float damageVal)
        {
            _health = healthVal;
            _name = nameVal;
            _damage = damageVal;
        }

        public void PrintStats()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Damage: " + _damage);
        }

        public string GetName()
        {
            return _name;
        }

        public bool Alive()
        {
            return _health > 0;
        }


    }

    
}
