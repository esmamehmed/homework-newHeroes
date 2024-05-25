using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    //-Frank's armor gets between 30-60% shield against damage
    //-has a 40% chance to cause double damage equal to his strength.
    internal class Commando : Hero
    {
        public Commando() : this("Sir Frank")
        {

        }

        public Commando(string name) : base(name)//A named soldier, we supply the name
        {

        }

        public override int Attack()
        {
            int baseAttack = base.Attack();
            int dice = Random.Shared.Next(0, 100);
            if (dice <= 40)
            {
                baseAttack = Strength * 2;
            }
            return base.Attack();
        }

        public override void TakeDamage(int incomingDamage)
        {
            int coef = Random.Shared.Next(30, 61);
            incomingDamage = incomingDamage - (coef * incomingDamage) / 100;
            base.TakeDamage(incomingDamage);
        }

       
    }
}
