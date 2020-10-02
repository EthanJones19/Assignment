using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Chupacabra : Enemy
    {
        public Chupacabra(float healthVal, string nameVal, float damageVal, float speedVal) :
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
