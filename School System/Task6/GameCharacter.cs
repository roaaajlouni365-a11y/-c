
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal abstract class GameCharacter
    {
        private String _name;
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _health;

        protected int Health
        {
            get { return _health; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _health = value;
                }
            }
        }

        public GameCharacter(String name, int health)
        {
            Name = name;
            Health = health;
        }

        public abstract void UseSpecialAbility();

        public virtual void TakeDamage(int amount)
        {
            if (amount > 0)
            {
                Health = Math.Max(0, Health - amount);
            }
        }

        public void Heal()
        {
            if ((Health + 10) <= 100)
            {
                Health += 10;
            }
            else
            {
                Health = 100;
            }

            Console.WriteLine($"{Name}'s health: {Health}");
        }

        public void Heal(int amount)
        {
            if (amount > 0)
            {
                if ((Health + amount) <= 100)
                {
                    Health += amount;
                }
                else
                {
                    Health = 100;
                }
            }

            Console.WriteLine($"{Name}'s health: {Health}");
        }

        public int GetHealth()
        {
            return Health;
        }
    }
}
