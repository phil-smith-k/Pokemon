using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PokeLibrary;

namespace PokemonUI
{

    public class ProgramUI
    {
        PokeService _pokeService = new PokeService();
        public void Run()
        {
            WelcomeUser();
            DisplaySearchPrompt();
        }
        private void DisplaySearchPrompt()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("See strengths and weaknesses of which type? (type below)");
                string userInput = Console.ReadLine();

                PokeTypes poke;
                if (Enum.TryParse(userInput, out poke))
                {

                    PokemonType pokeType = _pokeService.GetPokemonTypeAsync(userInput).Result;

                    Console.Clear();
                    Console.WriteLine($"The strengths and weaknesses of Type {pokeType.Name.ToString().ToUpper()}:\n");

                    DisplayAllDamageRelations(pokeType);
                    Console.ReadLine();

                }
                else
                {
                    continue;
                }
            }
        }
        private void WelcomeUser()
        {
            StreamReader stream = new StreamReader(@"C:\Users\pksmi\Documents\PersonalProjects\Pokemon\Pokemon\Pokemon.txt");
            string banner = stream.ReadToEnd();

            Console.WriteLine(banner);
            Console.WriteLine("Press enter to proceed...");
            Console.ReadLine();
        }
        private void DisplayDamageRelations(List<PokemonType> types)
        {
            foreach (var type in types)
            {
                Console.Write(type.Name.ToString().ToUpper() + " ");
            }
            Console.WriteLine("\n");
        }
        private void DisplayAllDamageRelations(PokemonType type)
        {
            Console.WriteLine("Inflicts No Damage To:");
            DisplayDamageRelations(type.Damage_Relations.No_Damage_To);

            Console.WriteLine("Inflicts Half Damage To:");
            DisplayDamageRelations(type.Damage_Relations.Half_Damage_To);

            Console.WriteLine("Inflicts Double Damage To:");
            DisplayDamageRelations(type.Damage_Relations.Double_Damage_To);

            Console.WriteLine("Receives No Damage From:");
            DisplayDamageRelations(type.Damage_Relations.No_Damage_From);

            Console.WriteLine("Receives Half Damage From:");
            DisplayDamageRelations(type.Damage_Relations.Half_Damage_From);

            Console.WriteLine("Receives Double Damage From:");
            DisplayDamageRelations(type.Damage_Relations.Double_Damage_From);
        }
    }
}
