using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Bandit : Enemy
    {

        public Bandit(string nameVal, float healthVal, float damageVal, float speedVal) :
            base(healthVal,nameVal,damageVal,speedVal)
        {

        }



        public override float Attack(Player player)
        {
            float maxDamage = _enemyDamage;
            return player.TakenDamage(maxDamage);
        }
    }

   
}
