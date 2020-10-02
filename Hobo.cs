using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace HelloWorld
{
    class Hobo : Player
    {
        private Item _stick;


        public Hobo()
        {

        }


        public Hobo(string nameVal, float healthVal, float damageVal, float speedVal, int moneyVal, int inventorySize) 
            : base(nameVal,healthVal,damageVal, speedVal, moneyVal, inventorySize)
        {
            
            _stick.name = "Stick";
            _stick.statIncrease = 2;
        }

        public override float Attack(Enemy enemy)
        {
            float maxDamage = _playerDamage + _equipedWeapon.statIncrease;
            return enemy.TakenDamage(maxDamage);
        }




    }
}
