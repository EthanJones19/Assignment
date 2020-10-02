using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace HelloWorld
{
    class Drunky : Enemy
    {


        public Drunky(string nameVal,float healthVal, float damageVal, float speedVal) :
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
