using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class HealthPotion : ICollectible
    {
        public string PotionName { get; set; }

        public HealthPotion(string potionName)
        {
            PotionName = potionName;
        }

        public void Collect()
        {
            Console.WriteLine($"{PotionName} collected!");
        }

        public void Use(GameCharacter character, string amountText)
        {
            try
            {
                int amount = Convert.ToInt32(amountText);

                character.Heal(amount);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input! Please enter a number.");
            }
        }
    }

}
