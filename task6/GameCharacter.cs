using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    abstract class GameCharacter
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected int Health { get; set; }

        public GameCharacter(string name, int health)
        {
            _name = name;

            if (health < 0)
            {
                Health = 0;
            }
            else if (health > 100)
            {
                Health = 100;
            }
            else
            {
                Health = health;
            }
        }

        public abstract void UseSpecialAbility();

        public virtual void TakeDamage(int amount)
        {
            if (amount < 0)
            {
                amount = 0;
            }

            Health = Health - amount;

            if (Health < 0)
            {
                Health = 0;
            }

            Console.WriteLine($"{Name} takes {amount} damage.");
        }

        public void Heal()
        {
            Health = Health + 10;

            if (Health > 100)
            {
                Health = 100;
            }

            Console.WriteLine($"{Name} heals 10 points.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }

        public void Heal(int amount)
        {
            if (amount < 0)
            {
                amount = 0;
            }

            Health = Health + amount;

            if (Health > 100)
            {
                Health = 100;
            }

            Console.WriteLine($"{Name} heals {amount} points.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }

        public void DisplayHealth()
        {
            Console.WriteLine($"{Name}'s health: {Health}");
        }
    }

}
