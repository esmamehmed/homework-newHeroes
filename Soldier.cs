using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    //-by jumping, he shakes the ground and cause a 50% damage
    //-every 6 hits can cause triple damage.

    internal class Soldier : Hero
    {
        public Soldier() : this("El Primo")
        {

        }

        public Soldier(string name) : base(name)//A named soldier, we supply the name
        {
            hitCount = 0;
        }
        private int hitCount;
        public override int Attack()
        {
            hitCount = hitCount + 1;
            int baseAttack = base.Attack();
            if (hitCount == 6)
            {
                baseAttack = baseAttack * 3;
                hitCount = 0;
            }
            return baseAttack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            int baseDamage = 100;
            double groundDamage = baseDamage * 0.5;
            base.TakeDamage(incomingDamage);
        }
          
        
    }
}
