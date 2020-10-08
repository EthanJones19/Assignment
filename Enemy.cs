using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Enemy
    {
        protected float _enemyHealth;
        protected string _enemyName;
        protected float _enemyDamage;
        protected float _enemySpeed;
        //Enemy's nothing stats
        public Enemy()
        {
            _enemyHealth = 100;
            _enemyName = "";
            _enemyDamage = 100;
            _enemySpeed = 100;
        }
        //Constructor
        public Enemy(float healthVal, string nameVal, float damageVal, float speedVal)
        {
            _enemyHealth = healthVal;
            _enemyName = nameVal;
            _enemyDamage = damageVal;
            _enemySpeed = speedVal;
        }
        //Prints enemy's stats
        public void EnemyStats()
        {
            Console.WriteLine("Name: " + _enemyName);
            Console.WriteLine("Life: " + _enemyHealth);
            Console.WriteLine("Damage: " + _enemyDamage);
            Console.WriteLine("Reaction Speed: " + _enemySpeed);
        }


        //Enemy takes damage function
        public virtual float TakenDamage(float damageVal)
        {
            _enemyHealth -= damageVal;
            if (_enemyHealth < 0)
            {
                _enemyHealth = 0;
            }
            return damageVal;

        }

        //Attack function for enemy
        public virtual float Attack(Player player)
        {
            float damageTaken = player.TakenDamage(_enemyDamage);
            return damageTaken;
        }

        //Returns enemy speed
        public float EnemySpeed()
        {
            return _enemySpeed;
        }

        //Enemy is alive function
        public bool EnemyAlive()
        {
            return _enemyHealth > 0;
        }

    }
}
