using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArenaGuide
{
    struct Character
    {
        public string Name;
        public float Health;
        public float Damage;
        public float Defense;
    }

    class Game
    {
        //Initialize character stats.
        Character character1;
        Character character2;

        /// <summary>
        /// Gets the total damage that should be subtracted from a characters health.
        /// </summary>
        /// <param name="damage">The damage stat of the attacker.</param>
        /// <param name="defense">The defense stat of the defender.</param>
        float CalculateDamage(float damage, float defense)
        {
            float damageReceived = damage - defense;

            if (damageReceived < 0)
                damageReceived = 0;

            return damageReceived;
        }

        /// <summary>
        /// Displays the stats given to the screen.
        /// </summary>
        void PrintStats(string name, float health, float damage, float defense)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Damage: " + damage);
            Console.WriteLine("Defense: " + defense);
        }

        /// <summary>
        /// Prints the current stats of the characters to the screen before waiting on an input to clear.
        /// </summary>
        void UpdateScreen()
        {
            PrintStats(character1.Name, character1.Health, character1.Damage, character1.Defense);
            Console.WriteLine();
            PrintStats(character2.Name, character2.Health, character2.Damage, character2.Defense);

            Console.ReadKey(true);
            Console.Clear();
        }

        public void Run()
        {
            character1.Name = "Character1";
            character1.Health = 100;
            character1.Damage = 10;
            character1.Defense = 5;

            character2.Name = "Character2";
            character2.Health = 80;
            character2.Damage = 15;
            character2.Defense = 2;

            //Display stats first for context.
            UpdateScreen();

            //Fighter 1 turn.
            Console.WriteLine(character1.Name + " atttacks!");
            character2.Health -= CalculateDamage(character1.Damage, character2.Defense);

            UpdateScreen();


            //Fighter 2 turn.
            Console.WriteLine(character2.Name + " atttacks!");
            character1.Health -= CalculateDamage(character2.Damage, character1.Defense);

            UpdateScreen();
        }
    }
}
