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

        public Enemy()
        {
            _enemyHealth = 100;
            _enemyName = "";
            _enemyDamage = 100;
            _enemySpeed = 100;
        }

        public Enemy(float healthVal, string nameVal, float damageVal, float speedVal)
        {
            _enemyHealth = healthVal;
            _enemyName = nameVal;
            _enemyDamage = damageVal;
            _enemySpeed = speedVal;
        }

        public void EnemyStats()
        {
            Console.WriteLine("Name: " + _enemyName);
            Console.WriteLine("Life: " + _enemyHealth);
            Console.WriteLine("Damage: " + _enemyDamage);
            Console.WriteLine("Reaction Speed: " + _enemySpeed);
        }



        public virtual float TakenDamage(float damageVal)
        {
            _enemyHealth -= damageVal;
            if (_enemyHealth < 0)
            {
                _enemyHealth = 0;
            }
            return damageVal;

        }


        public virtual float Attack(Player player)
        {
            float damageTaken = player.TakenDamage(_enemyDamage);
            return damageTaken;
        }

        public bool EnemySpeed(float speedVal)
        {
            return _enemySpeed >= speedVal;
        }

        



        public bool EnemyAlive()
        {
            return _enemyHealth > 0;
        }

    }
}
