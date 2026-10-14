
using System;

namespace task6
{
    internal class HealthPotion : ICollectible
    {
        public String PotionName { get; set; }

        public void Collect()
        {
            Console.WriteLine("Health Potion collected!");
        }

        public void Use(GameCharacter character, string amountText)
        {
            try
            {
                int amountInt = Convert.ToInt32(amountText);
                character.Heal(amountInt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input! Please enter a number.");
            }
        }
    }
}