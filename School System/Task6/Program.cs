using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ADVENTURE GAME =====");

            Warrior warrior = new Warrior("Alex", 80);
            Wizard wizard = new Wizard("Luna", 70);

            List<GameCharacter> characters = new List<GameCharacter>();

            characters.Add(warrior);
            characters.Add(wizard);

            foreach (GameCharacter character in characters)
            {
                Console.WriteLine(character.Name);
                character.UseSpecialAbility();
            }

            warrior.TakeDamage(10);
            wizard.TakeDamage(10);

            Console.WriteLine($"{warrior.Name}'s health: {warrior.GetHealth()}");
            Console.WriteLine($"{wizard.Name}'s health: {wizard.GetHealth()}");

            warrior.Heal();
            warrior.Heal(15);

            wizard.Heal();
            wizard.Heal(10);

            HealthPotion potion = new HealthPotion();

            potion.Collect();

            potion.Use(wizard, "15");
            potion.Use(wizard, "abc");
        }
    }
}
