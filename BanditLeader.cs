using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class BanditLeader : Enemy
    {

        public BanditLeader(float healthVal, string nameVal, float damageVal, float speedVal) :
            base(healthVal, nameVal, damageVal, speedVal)
        {

        }


        public override float Attack(Player player)
        {
            float maxDamage = _enemyDamage;
            return player.TakenDamage(maxDamage);
        }

    }

    
}
