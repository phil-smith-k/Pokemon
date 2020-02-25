using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PokeLibrary
{
    public class PokeService
    {
        HttpClient _httpClient = new HttpClient();
        public async Task<PokemonType> GetPokemonTypeAsync(string pokeType)
        {
            HttpResponseMessage typeResponse = await _httpClient.GetAsync($"https://pokeapi.co/api/v2/type/{pokeType}");

            if (typeResponse.IsSuccessStatusCode)
            {
                return await typeResponse.Content.ReadAsAsync<PokemonType>();
            }
            return null;
        }
    }
}
