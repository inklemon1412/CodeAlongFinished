using CodeAlongFinished; 
var fight = new FightManager();
Pokemon pokemon = new Pokemon();
List<Pokemon> allPokemon = new List<Pokemon>()
            {

                new Pokemon("Pikachu", "Electric", 40, 50),
                new Pokemon("Eevee", "Normal", 20, 10),
                new Pokemon("Grovyle", "Grass", 60, 100),
            };
Main();

void Main()
{
    while (true)
    {

        Console.WriteLine("What would you like to do?");

        MainMenu();
    }
}
void MainMenu()
{


    Console.WriteLine("1) See Pokemon");
    Console.WriteLine("2) Go to battleMenu");

    var userInput = Console.ReadLine();
    switch (userInput)
    {
        case "1":
            pokemon.PokemonMenu(allPokemon);
            break;
        case "2":
            fight.PrepareFight();
            break;







    }
}
