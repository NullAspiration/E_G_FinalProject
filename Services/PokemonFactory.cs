using E_G_FinalProject.Models.ViewModels;

namespace E_G_FinalProject.Services
{
    public class PokemonFactory
    {
        private readonly PokeApiService _pokeApiService;

        public PokemonFactory(PokeApiService pokeApiService)
        {
            _pokeApiService = pokeApiService;
        }

        public async Task<PokemonVM> GetPokemon(int id)
        {
            var pokemon = await _pokeApiService.GetPokemon(id);
            var viewModel = new PokemonVM(pokemon)
            {
                Name = pokemon.Name,
                ImageUrl = pokemon.Sprites,
                Type = pokemon.Types.FirstOrDefault(),
                Height = pokemon.Height / 10.0,
                Weight = pokemon.Weight / 10.0
            };
            return viewModel;
        }
    }
}
