using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArenaGuide
{

    class Game
    {
        //Initialize character stats.
        string character1Name = "Character 1";
        float character1Health = 100;
        float character1Damage = 10;
        float character1Defense = 5;

        string character2Name = "Character 2";
        float character2Health = 80;
        float character2Damage = 15;
        float character2Defense = 2;

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
            PrintStats(character1Name, character1Health, character1Damage, character1Defense);
            Console.WriteLine();
            PrintStats(character2Name, character2Health, character2Damage, character2Defense);

            Console.ReadKey(true);
            Console.Clear();
        }

        public void Run()
        {
            //Display stats first for context.
            UpdateScreen();

            //Fighter 1 turn.
            Console.WriteLine(character1Name + " atttacks!");
            character2Health -= CalculateDamage(character1Damage, character2Defense);

            UpdateScreen();


            //Fighter 2 turn.
            Console.WriteLine(character2Name + " atttacks!");
            character1Health -= CalculateDamage(character2Damage, character1Defense);

            UpdateScreen();
        }
    }
}
