using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Warrior : GameCharacter
    {
        public Warrior(String name, int health) : base(name, health)
        {

        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Warrior attacks with a sword!");
        }

        public override void TakeDamage(int amount)
        {
            if (amount > 0)
            {
                Health = Math.Max(0, Health - Math.Max(0, amount - 2));
            }
        }
    }
}
