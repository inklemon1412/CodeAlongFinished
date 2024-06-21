using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongFinished
{
    internal class Pokemon
    {
        public string _name;
        public string _type;
        public int _strength;
        public int _health;

        public Pokemon(string Name, string Type, int Strength, int Health)
        {
            _name = Name;
            _type = Type;
            _strength = Strength;
            _health = Health;
        }
        public Pokemon()
        {

        }

        public void PokemonMenu(List<Pokemon> allPokemon)
        {
            PrintAllPokemon(allPokemon);
        }

        public void PrintAllPokemon(List<Pokemon> allPokemon)
        {

            foreach (var pokemon in allPokemon)
            {
                Console.WriteLine($"Pokemon Name: {pokemon._name}");
                Console.WriteLine($"Pokemon Type: {pokemon._type}");
                Console.WriteLine($"Pokemon Health: {pokemon._health}");
                Console.WriteLine($"Pokemon Strength: {pokemon._strength}");
            }
        }
    }
}
