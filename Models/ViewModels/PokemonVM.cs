using E_G_FinalProject.Models.Entities;
namespace E_G_FinalProject.Models.ViewModels
{
    public class PokemonVM
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Type { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public PokemonVM(Pokemon pokemon)
        {
            Id = 0;
            Name = pokemon.Name;
            ImageUrl = pokemon.Sprites;
            Type = pokemon.Types.FirstOrDefault();
            Height = pokemon.Height / 10.0;
            Weight = pokemon.Weight / 10.0;
        }
    }
}
