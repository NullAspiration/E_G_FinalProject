using System.Text.Json.Serialization;

namespace E_G_FinalProject.Services
{
    public class PokeApiService
    {
        private readonly HttpClient _httpClient;

        public PokeApiService(HttpClient httpClient)
        { 
            _httpClient = httpClient;
        }

        public async Task<Pokemon> GetPokemon(int id)
        { 
            var url = $"https://pokeapi.co/api/v2/pokemon/{id}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var pokemon = JsonConvert.DeserializeObject<Pokemon>(json);
            return pokemon;
        }
    }
}
