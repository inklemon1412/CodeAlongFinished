using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongFinished
{
    internal class FightManager
    {
        public Pokemon _ChosenPokemon;
        public Pokemon _ChosenEnemy;

        public void PrepareFight()
        {
            while (true)
            {
                Console.WriteLine("Choose a pokemon");
                Console.WriteLine("Once choosen, 4 to commence battle");
                var userChoice = Console.ReadLine();
                if (userChoice == "1")
                {
                    _ChosenPokemon = new Pokemon("Eevee", "Normal", 40, 20);
                    Console.WriteLine($"You chose: {_ChosenPokemon._name}");
                    _ChosenEnemy = new Pokemon("Pikachu", "Electric", 40, 50);


                }
                if (userChoice == "2")
                {
                    _ChosenPokemon = new Pokemon("Pikachu", "Electric", 40, 50);
                    Console.WriteLine($"You chose: {_ChosenPokemon._name}");
                    _ChosenEnemy = new Pokemon("Grovyle", "Grass", 60, 100);
                }
                if (userChoice == "3")
                {
                    _ChosenPokemon = new Pokemon("Grovyle", "Grass", 60, 100);
                    Console.WriteLine($"You chose: {_ChosenPokemon._name}");
                    _ChosenEnemy = new Pokemon("Eevee", "Normal", 40, 20);
                }
                if (userChoice == "4")
                {
                    Battle();
                }
                else
                {
                    Console.WriteLine("invalid type");
                }
            }
        }



        public void Battle()
        {



            Console.WriteLine($"1 to attack");
            Console.WriteLine($"2 to catch");
            string userInput = Console.ReadLine();


            if (userInput == "1")
            {
                int enemyHealth = _ChosenEnemy._health;
                int playerHealth = _ChosenPokemon._health;
                string player = _ChosenPokemon._name;
                string enemy = _ChosenEnemy._name;

                while (enemyHealth > 0 && playerHealth > 0)
                {
                    Console.WriteLine("Player pokemon has" + playerHealth + "health. And enemy pokemon has" + enemyHealth + "health");
                    Console.WriteLine("press 1 to attack");
                    string userChoice = Console.ReadLine();
                    int enemyStrength = new Random().Next(0, 10);
                    int playerStrength = new Random().Next(0, 10);

                    if (userChoice == "1")
                    {
                        Console.WriteLine(player + "attacked" + enemy + " for " + playerStrength + "damage");
                        Console.WriteLine(enemy + "attacked" + player + " for " + enemyStrength + "damage");
                        playerHealth -= enemyStrength;
                        enemyHealth -= playerStrength;
                    }

                    if (enemyHealth < 0 || playerHealth < 0)
                    {
                        Console.WriteLine("Game over due to sudden death");
                    }

                    else if (userInput == "2")
                    {
                        Console.WriteLine("You tried to catch" + enemy);
                        Console.WriteLine(enemy + "added to pokemons");
                    }
                }
            }
        }
    }
}
