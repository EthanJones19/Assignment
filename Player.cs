using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HelloWorld
{
    class Player : Hobo
    {
        private float _playerHealth;
        private string _playerName;
        private float _playerDamage;
        private int _playerMoney;
        private float _playerSpeed;


        public Player()
        {
            _playerHealth = 100;
            _playerName = "Some Hobo";
            _playerDamage = 20;

        }

        public Player(float healthVal, string nameVal, float damageVal, float speedVal, int moneyVal) 
        {
            _playerHealth = healthVal;
            _playerName = nameVal;
            _playerDamage = damageVal;
            _playerSpeed = speedVal;
            _playerMoney = moneyVal;
        }

        public void PlayerStats()
        {
            Console.WriteLine("Name: " + _playerName);
            Console.WriteLine("Life: " + _playerHealth);
            Console.WriteLine("Damage: " + _playerDamage);
            Console.WriteLine("Money: " + _playerMoney);
            Console.WriteLine("Reaction Speed: " + _playerSpeed);
        }

        
        public string GetPlayerName()
        {
            return _playerName;
        }

        public bool Alive()
        {
            return _playerHealth > 0;
        }

        public override float Attack(Player enemy)
        {
            float maxDamage = _playerDamage + _equipedWeapon.statIncrease;
            float maxSpeed = _playerSpeed = _equipedArmor.statIncrease;
            return enemy.
        }


    }

    
}
