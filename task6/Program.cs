using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("===== ADVENTURE GAME =====");

                // Create objects
                Warrior warrior = new Warrior("Alex", 80);
                Wizard wizard = new Wizard("Luna", 70);

                Console.WriteLine("\nWarrior Alex enters the game!");
                Console.WriteLine("Wizard Luna enters the game!");

                // Store characters in a List
                List<GameCharacter> characters = new List<GameCharacter>();

                characters.Add(warrior);
                characters.Add(wizard);

                // Call special abilities and take damage
                foreach (GameCharacter character in characters)
                {
                    character.UseSpecialAbility();
                    character.TakeDamage(10);
                    character.DisplayHealth();

                    Console.WriteLine();
                }

                // Test Heal() - adds 10 health points
                warrior.Heal();

                Console.WriteLine();

                // Test Heal(int amount) - adds the given amount
                warrior.Heal(15);

                Console.WriteLine();

                // Create and collect a health potion
                HealthPotion potion = new HealthPotion("Health Potion");

                potion.Collect();

                Console.WriteLine();

                // Use potion with valid input
                potion.Use(wizard, "15");

                Console.WriteLine();

                // Use potion with invalid input
                potion.Use(wizard, "abc");
            }
        }
    }
}
